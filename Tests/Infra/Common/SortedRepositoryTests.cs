using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Aids.Reflection;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Tests.Infra.Common
{
    [TestClass]
    public class SortedRepositoryTests : AbstractClassTests<SortedRepository<America, AmericaData>,
        BaseRepository<America, AmericaData>>
    {
        private class testClass : SortedRepository<America, AmericaData>
        {
            public testClass(DbContext c, DbSet<AmericaData> s) : base(c, s) { }

            public override America toDomainObjects(AmericaData d) => new America(d);


            protected override async Task<AmericaData> getData(string id)
            {
                await Task.CompletedTask;
                return new AmericaData();
            }
            protected override string getId(America entity) => entity?.Data?.Id;
        }
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<AirFreightDbContext>().UseInMemoryDatabase("TestDb").Options;
            var c = new AirFreightDbContext(options);
            obj = new testClass(c, c.America);
        }
        [TestMethod]
        public void SortOrderTest()
        {
            isNullableProperty(() => obj.SortOrder, x => obj.SortOrder = x);
        }

        [TestMethod]
        public void SetSortingTest()
        {
            void test(IQueryable<AmericaData> d, string sortOrder)
            {
                obj.SortOrder = sortOrder + obj.DescendingString;
                var set = obj.addSorting(d);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString()
                    .Contains(
                        $"SemestriProject.Data.AirFreight.AmericaData]).OrderByDescending(x => Convert(Param_0.{sortOrder}, Object))"));
                obj.SortOrder = sortOrder;
                set = obj.addSorting(d);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString()
                    .Contains(
                        $"SemestriProject.Data.AirFreight.AmericaData]).OrderBy(x => Convert(x.{sortOrder}, Object))"));
            }
        }

        [TestMethod]
        public void DescendingStringTest()
        {
            var propertyName = GetMember.Name<testClass>(x => x.DescendingString);
            isReadOnlyProperty(obj, propertyName, "_desc");
        }
        [TestMethod]
        public void CreateExpressionTest()
        {
            string s;
            testCreateExpression(GetMember.Name<AmericaData>(x => x.OrderTime));
            testCreateExpression(GetMember.Name<AmericaData>(x => x.Id));
            testCreateExpression(GetMember.Name<AmericaData>(x => x.Direction));
            testCreateExpression(GetMember.Name<AmericaData>(x => x.TravelTime));
            testCreateExpression(s = GetMember.Name<AmericaData>(x => x.OrderTime), s + obj.DescendingString);
            testCreateExpression(s = GetMember.Name<AmericaData>(x => x.Id), s + obj.DescendingString);
            testCreateExpression(s = GetMember.Name<AmericaData>(x => x.Direction), s + obj.DescendingString);
            testCreateExpression(s = GetMember.Name<AmericaData>(x => x.TravelTime), s + obj.DescendingString);
            testNullExpression(GetRandom.String());
            testNullExpression(string.Empty);
            testNullExpression(null);
        }
        private void testCreateExpression(string expected, string name = null)
        {
            name ??= expected;
            obj.SortOrder = name;
            var lambda = obj.createExpression();
            Assert.IsNotNull(lambda);
            Assert.IsInstanceOfType(lambda, typeof(Expression<Func<AmericaData, object>>));
            Assert.IsTrue(lambda.ToString().Contains(expected));
        }
        private void testNullExpression(string name)
        {
            obj.SortOrder = name;
            var lambda = obj.createExpression();
            Assert.IsNull(lambda);
        }
        [TestMethod]
        public void LambdaExpressionTest()
        {
            var name = GetMember.Name<AmericaData>(x => x.OrderTime);
            var property = typeof(AmericaData).GetProperty(name);
            var lambda = obj.lambdaExpression(property);
            Assert.IsNotNull(lambda);
            Assert.IsInstanceOfType(lambda, typeof(Expression<Func<AmericaData, object>>));
            Assert.IsTrue(lambda.ToString().Contains(name));
        }

        [TestMethod]
        public void FindPropertyTest()
        {
            string s;
            void test(PropertyInfo expected, string sortOrder)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.findProperty());
            }
            test(null, GetRandom.String());
            test(null, null);
            test(null, string.Empty);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.OrderTime)), s);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.Direction)), s);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.TravelTime)), s);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.Id)), s);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.OrderTime)), s + obj.DescendingString);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.Direction)), s + obj.DescendingString);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.TravelTime)), s + obj.DescendingString);
            test(typeof(AmericaData).GetProperty(s = GetMember.Name<AmericaData>(x => x.Id)), s + obj.DescendingString);
        }

        [TestMethod]
        public void GetNameTest()
        {
            string s;
            void test(string expected, string sortOrder)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.getName());
            }
            test(s = GetRandom.String(), s);
            test(s = GetRandom.String(), s + obj.DescendingString);
            test(string.Empty, string.Empty);
            test(string.Empty, null);
        }

        [TestMethod]
        public void SortOrderByTest()
        {
            void test(IQueryable<AmericaData> d, Expression<Func<AmericaData, object>> e, string expected)
            {
                obj.SortOrder = GetRandom.String() + obj.DescendingString;
                var set = obj.addOrderBy(d, e);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString()
                    .Contains($"SemestriProject.Data.AirFreight.AmericaData]).OrderByDescending({expected})"));
                obj.SortOrder = GetRandom.String();
                set = obj.addOrderBy(d, e);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString().Contains($"SemestriProject.Data.AirFreight.AmericaData]).OrderBy({expected})"));
            }

            Assert.IsNull(obj.addOrderBy(null, null));
            IQueryable<AmericaData> data = obj.dbSet;
            Assert.AreEqual(data, obj.addOrderBy(data, null));
            test(data, x => x.Id, "x => x.Id");
            test(data, x => x.Direction, "x => x.Direction");
            test(data, x => x.TravelTime, "x => x.TravelTime");
            test(data, x => x.OrderTime, "x => x.OrderTime");
            test(data, x => x.ReadyForCollection, "x => Convert(x.ReadyForCollection, Object)");
            test(data, x => x.RequestedDeliveryTime, "x => Convert(x.RequestedDeliveryTime, Object)");
        }

        [TestMethod]
        public void isDescendingTest()
        {
            void test(string sortOrder, bool expected)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.isDescending());
            }
            test(GetRandom.String(), false);
            test(GetRandom.String() + obj.DescendingString, true);
            test(string.Empty, false);
            test(null, false);
        }
    }
}

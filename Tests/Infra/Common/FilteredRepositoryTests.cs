using System;
using System.Collections.Generic;
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
    public class FilteredRepositoryTests : AbstractClassTests<FilteredRepository<America, AmericaData>,
        SortedRepository<America, AmericaData>>
    {
        private class testClass : FilteredRepository<America, AmericaData>
        {

            public testClass(DbContext c, DbSet<AmericaData> s) : base(c, s) { }

            public override America toDomainObjects(AmericaData d) => new America(d);

            protected override async Task<AmericaData> getData(string id)
            {
                return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
            }

            protected override string getId(America entity) => entity?.Data?.Id;

        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();

            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new AirFreightDbContext(options);
            obj = new testClass(c, c.America);
        }

        [TestMethod]
        public void SearchStringTest()
            => isNullableProperty(() => obj.SearchString, x => obj.SearchString = x);

        [TestMethod]
        public void FixedFilterTest()
            => isNullableProperty(() => obj.FixedFilter, x => obj.FixedFilter = x);

        [TestMethod]
        public void FixedValueTest()
            => isNullableProperty(() => obj.FixedValue, x => obj.FixedValue = x);

        [TestMethod]
        public void createSqlQueryTest()
        {
            var sql = obj.createSqlQuery();
            Assert.IsNotNull(sql);
        }

        [TestMethod]
        public void addFixedFilteringTest()
        {
            var sql = obj.createSqlQuery();
            var fixedFilter = GetMember.Name<AmericaData>(x => x.TypeOfCargo);
            obj.FixedFilter = fixedFilter;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var sqlNew = obj.addFixedFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void createFixedWhereExpressionTest()
        {
            var properties = typeof(AmericaData).GetProperties();
            var idx = GetRandom.Int32(0, properties.Length);
            var p = properties[idx];
            obj.FixedFilter = p.Name;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var e = obj.createFixedWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            var expected = p.Name;
            if (p.PropertyType != typeof(string))
                expected += ".ToString()";
            expected += $" == \"{fixedValue}\"";
            Assert.IsFalse(s.Contains(expected));
        }

        [TestMethod]
        public void createFixedWhereExpressionOnFixedFilterNullTest()
        {
            Assert.IsNull(obj.createFixedWhereExpression());
            obj.FixedValue = GetRandom.String();
            obj.FixedFilter = GetRandom.String();
            Assert.IsNull(obj.createFixedWhereExpression());
        }

        [TestMethod]
        public void addFilteringTest()
        {
            var sql = obj.createSqlQuery();
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var sqlNew = obj.addFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void createWhereExpressionTest()
        {
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var e = obj.createWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            foreach (var p in typeof(AmericaData).GetProperties())
            {
                var expected = p.Name;
                if (p.PropertyType != typeof(string))
                    expected += ".ToString()";
                expected += $".Contains(\"{searchString}\")";
                Assert.IsTrue(s.Contains(expected));
            }
        }
        [TestMethod]
        public void createWhereExpressionWithNullSearchStringTest()
        {
            obj.SearchString = null;
            var e = obj.createWhereExpression();
            Assert.IsNull(e);
        }

    }
}

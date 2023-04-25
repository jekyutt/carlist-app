using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Reflection;
using SemestriProject.Data.Order;
using SemestriProject.Infra.Order;

namespace SemestriProject.Tests.Infra.Order
{
    [TestClass]
    public class OrderDbContextTests : BaseClassTests<OrderDbContext, DbContext>
    {
        private DbContextOptions<OrderDbContext> options;
        private class testClass : OrderDbContext
        {
            public testClass(DbContextOptions<OrderDbContext> o) : base(o) { }
            public ModelBuilder RunOnModelCreating()
            {
                var set = new ConventionSet();
                var mb = new ModelBuilder(set);
                OnModelCreating(mb);
                return mb;
            }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            options = new DbContextOptionsBuilder<OrderDbContext>().Options;
            obj = new OrderDbContext(options);
        }

        [TestMethod]
        public void InitializeTablesTest()
        {
            static void testKey<T>(IMutableEntityType entity, params Expression<Func<T, object>>[] values)
            {
                var key = entity.FindPrimaryKey();

                if (values is null) Assert.IsNull(key);
                else
                    foreach (var v in values)
                    {
                        var name = GetMember.Name(v);
                        Assert.IsNotNull(key.Properties.FirstOrDefault(x => x.Name == name));
                    }
            }

            static void testEntity<T>(ModelBuilder b, params Expression<Func<T, object>>[] values)
            {
                var name = typeof(T).FullName ?? string.Empty;
                var entity = b.Model.FindEntityType(name);
                Assert.IsNotNull(entity, name);
                testKey(entity, values);
            }

            OrderDbContext.InitializeTables(null);
            var o = new testClass(options);
            var builder = o.RunOnModelCreating();
            OrderDbContext.InitializeTables(builder);
            testEntity<MakeOrderData>(builder, x => x.Id, x => x.Id);
            
        }


        [TestMethod]
        public void MakeOrderTest() =>
            isNullableProperty(obj, nameof(obj.MakeOrder), typeof(DbSet<MakeOrderData>));


    }
}

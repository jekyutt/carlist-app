using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Reflection;
using SemestriProject.Data.AirFreight;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.RoadFreight;

namespace SemestriProject.Tests.Infra.RoadFreight
{
    [TestClass]
    public class RoadFreightDbContextTests : BaseClassTests<RoadFreightDbContext, DbContext>
    {
        private DbContextOptions<RoadFreightDbContext> options;
        private class testClass : RoadFreightDbContext
        {
            public testClass(DbContextOptions<RoadFreightDbContext> o) : base(o) { }
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
            options = new DbContextOptionsBuilder<RoadFreightDbContext>().Options;
            obj = new RoadFreightDbContext(options);
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

            AirFreightDbContext.InitializeTables(null);
            var o = new testClass(options);
            var builder = o.RunOnModelCreating();
            AirFreightDbContext.InitializeTables(builder);
            testEntity<BalticData>(builder, x => x.Id, x => x.Id);
            testEntity<RussiaAndCISData>(builder, x => x.Id, x => x.Id);
            testEntity<ChinaData>(builder, x => x.Id, x => x.Id);
        }


        [TestMethod]
        public void UnitFactorsTest() =>
            isNullableProperty(obj, nameof(obj.Baltics), typeof(DbSet<BalticData>));

        [TestMethod]
        public void UnitTermsTest() =>
            isNullableProperty(obj, nameof(obj.RussiaAndCIS), typeof(DbSet<RussiaAndCISData>));

        [TestMethod]
        public void MeasureTermsTest() =>
            isNullableProperty(obj, nameof(obj.Scandinavia), typeof(DbSet<ScandinaviaData>));

    }
}

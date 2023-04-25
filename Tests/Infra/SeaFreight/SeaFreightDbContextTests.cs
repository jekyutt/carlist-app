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
using SemestriProject.Data.SeaFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.RoadFreight;
using SemestriProject.Infra.SeaFreight;

namespace SemestriProject.Tests.Infra.SeaFreight
{
    [TestClass]
    public class SeaFreightDbContextTests : BaseClassTests<SeaFreightDbContext, DbContext>
    {
        private DbContextOptions<SeaFreightDbContext> options;
        private class testClass : SeaFreightDbContext
        {
            public testClass(DbContextOptions<SeaFreightDbContext> o) : base(o) { }
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
            options = new DbContextOptionsBuilder<SeaFreightDbContext>().Options;
            obj = new SeaFreightDbContext(options);
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
            testEntity<EuropeData>(builder, x => x.Id, x => x.Id);
            testEntity<AfricaData>(builder, x => x.Id, x => x.Id);
           
        }


        [TestMethod]
        public void UnitFactorsTest() =>
            isNullableProperty(obj, nameof(obj.Europe), typeof(DbSet<EuropeData>));

        [TestMethod]
        public void UnitTermsTest() =>
            isNullableProperty(obj, nameof(obj.Africa), typeof(DbSet<AfricaData>));


    }
}

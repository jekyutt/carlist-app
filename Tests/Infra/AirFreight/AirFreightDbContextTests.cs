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
using SemestriProject.Infra.AirFreight;

namespace SemestriProject.Tests.Infra.AirFreight
{
    [TestClass]
    public class AirFreightDbContextTests : BaseClassTests<AirFreightDbContext, DbContext>
    {
        private DbContextOptions<AirFreightDbContext> options;
        private class testClass : AirFreightDbContext
        {
            public testClass(DbContextOptions<AirFreightDbContext> o) : base(o) { }
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
            options = new DbContextOptionsBuilder<AirFreightDbContext>().Options;
            obj = new AirFreightDbContext(options);
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
            testEntity<AmericaData>(builder, x => x.Id, x => x.Id);
            testEntity<AustraliaData>(builder, x => x.Id, x => x.Id);
            testEntity<ChinaData>(builder, x => x.Id, x => x.Id);
        }


        [TestMethod]
        public void AmericaTest() =>
            isNullableProperty(obj, nameof(obj.America), typeof(DbSet<AmericaData>));

        [TestMethod]
        public void AustraliaTest() =>
            isNullableProperty(obj, nameof(obj.Australia), typeof(DbSet<AustraliaData>));

        [TestMethod]
        public void ChinaTest() =>
            isNullableProperty(obj, nameof(obj.China), typeof(DbSet<ChinaData>));

    }
}

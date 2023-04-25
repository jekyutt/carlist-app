using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Infra.Common;
using SemestriProject.Infra.SeaFreight;

namespace SemestriProject.Tests.Infra.SeaFreight
{
    [TestClass]
    public class AfricaRepositoryTests : RepositoryTests<AfricaRepository, Africa, AfricaData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SeaFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SeaFreightDbContext(options);
            dbSet = ((SeaFreightDbContext)db).Africa;
            obj = new AfricaRepository((SeaFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<Africa, AfricaData>);

        protected override string getId(AfricaData d) => d.Id;

        protected override Africa getObject(AfricaData d) => new Africa(d);

        protected override void setId(AfricaData d, string id) => d.Id = id;
    }
}

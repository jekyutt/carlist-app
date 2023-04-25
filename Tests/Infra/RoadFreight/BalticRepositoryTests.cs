using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.AirFreight;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Common;
using SemestriProject.Infra.RoadFreight;

namespace SemestriProject.Tests.Infra.RoadFreight
{
    [TestClass]
    public class BalticRepositoryTests : RepositoryTests<BalticsRepository, Baltic, BalticData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<RoadFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new RoadFreightDbContext(options);
            dbSet = ((RoadFreightDbContext)db).Baltics;
            obj = new BalticsRepository((RoadFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<Baltic, BalticData>);

        protected override string getId(BalticData d) => d.Id;

        protected override Baltic getObject(BalticData d) => new Baltic(d);

        protected override void setId(BalticData d, string id) => d.Id = id;
    }
}

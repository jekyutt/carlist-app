using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Infra.Common;
using SemestriProject.Infra.RoadFreight;

namespace SemestriProject.Tests.Infra.RoadFreight
{
    [TestClass]
    public class RussiaCISRepositoryTests : RepositoryTests<RussiaCISRepository, RussiaAndCIS, RussiaAndCISData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<RoadFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new RoadFreightDbContext(options);
            dbSet = ((RoadFreightDbContext)db).RussiaAndCIS;
            obj = new RussiaCISRepository((RoadFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<RussiaAndCIS, RussiaAndCISData>);

        protected override string getId(RussiaAndCISData d) => d.Id;

        protected override RussiaAndCIS getObject(RussiaAndCISData d) => new RussiaAndCIS(d);

        protected override void setId(RussiaAndCISData d, string id) => d.Id = id;
    }
}

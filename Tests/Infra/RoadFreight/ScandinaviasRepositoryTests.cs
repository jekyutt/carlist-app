using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Infra.Common;
using SemestriProject.Infra.RoadFreight;

namespace SemestriProject.Tests.Infra.RoadFreight
{
    [TestClass]
    public class ScandinaviasRepositoryTests : RepositoryTests<ScandinaviasRepository, Scandinavia, ScandinaviaData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<RoadFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new RoadFreightDbContext(options);
            dbSet = ((RoadFreightDbContext)db).Scandinavia;
            obj = new ScandinaviasRepository((RoadFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<Scandinavia, ScandinaviaData>);

        protected override string getId(ScandinaviaData d) => d.Id;

        protected override Scandinavia getObject(ScandinaviaData d) => new Scandinavia(d);

        protected override void setId(ScandinaviaData d, string id) => d.Id = id;
    }
}

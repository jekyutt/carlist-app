using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Infra.Common;
using SemestriProject.Infra.SeaFreight;

namespace SemestriProject.Tests.Infra.SeaFreight
{
    [TestClass]
    public class EuropeRepositoryTests : RepositoryTests<EuropeRepository, Europe, EuropeData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<SeaFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new SeaFreightDbContext(options);
            dbSet = ((SeaFreightDbContext)db).Europe;
            obj = new EuropeRepository((SeaFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<Europe, EuropeData>);

        protected override string getId(EuropeData d) => d.Id;

        protected override Europe getObject(EuropeData d) => new Europe(d);

        protected override void setId(EuropeData d, string id) => d.Id = id;
    }
}

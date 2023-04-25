using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Tests.Infra.AirFreight
{
    [TestClass]
    public class ChinaRepositoryTests : RepositoryTests<ChinaRepository, China, ChinaData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirFreightDbContext(options);
            dbSet = ((AirFreightDbContext)db).China;
            obj = new ChinaRepository((AirFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<China, ChinaData>);

        protected override string getId(ChinaData d) => d.Id;

        protected override China getObject(ChinaData d) => new China(d);

        protected override void setId(ChinaData d, string id) => d.Id = id;
    }
}

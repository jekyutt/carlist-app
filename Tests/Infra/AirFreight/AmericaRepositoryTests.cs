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
    public class AmericaRepositoryTests : RepositoryTests<AmericaRepository, America, AmericaData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirFreightDbContext(options);
            dbSet = ((AirFreightDbContext)db).America;
            obj = new AmericaRepository((AirFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<America, AmericaData>);

        protected override string getId(AmericaData d) => d.Id;

        protected override America getObject(AmericaData d) => new America(d);

        protected override void setId(AmericaData d, string id) => d.Id = id;
    }
}


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
    public class AustraliaRepositoryTests : RepositoryTests<AustraliaRepository, Australia, AustraliaData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirFreightDbContext(options);
            dbSet = ((AirFreightDbContext)db).Australia;
            obj = new AustraliaRepository((AirFreightDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType() => typeof(UniqueEntityRepository<Australia, AustraliaData>);

        protected override string getId(AustraliaData d) => d.Id;

        protected override Australia getObject(AustraliaData d) => new Australia(d);

        protected override void setId(AustraliaData d, string id) => d.Id = id;
    }
}

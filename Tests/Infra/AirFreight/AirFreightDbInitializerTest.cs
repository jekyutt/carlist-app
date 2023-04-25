using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Infra.AirFreight;

namespace SemestriProject.Tests.Infra.AirFreight
{
    [TestClass]
    public class AirFreightDbInitializerTest : BaseTests
    {
        private AirFreightDbContext db;
        [TestMethod] public void InitializeTest() { }

        [TestInitialize]
        public void TestInitialize()
        {
            type = typeof(AirFreightDbInitializer);
            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirFreightDbContext(options);
            AirFreightDbInitializer.Initialize(db);
        }
    }
}

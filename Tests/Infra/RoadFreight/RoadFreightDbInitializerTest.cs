using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Infra.RoadFreight;

namespace SemestriProject.Tests.Infra.RoadFreight
{
    [TestClass]
    public class RoadFreightDbInitializerTest : BaseTests
    {
        private RoadFreightDbContext db;
        [TestInitialize]
        public void TestInitialize()
        {
            type = typeof(RoadFreightDbInitializer);
            var options = new DbContextOptionsBuilder<RoadFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new RoadFreightDbContext(options);
            RoadFreightDbInitializer.Initialize(db);
        }

        [TestMethod] public void InitializeTest() { }
    }
}

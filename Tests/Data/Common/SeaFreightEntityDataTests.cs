using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;

namespace SemestriProject.Tests.Data.Common
{
    [TestClass]
    public class SeaFreightEntityDataTests : AbstractClassTests<SeaFreightEntityData, DefinedEntityData>
    {
        private class testClass : SeaFreightEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void LiftingCapacityTest()
        {
            isNullableProperty(() => obj.LiftingCapacity, x => obj.LiftingCapacity = x);
        }

        [TestMethod]
        public void ContainerTypeTest()
        {
            isNullableProperty(() => obj.ContainerType, x => obj.ContainerType = x);
        }




    }
}

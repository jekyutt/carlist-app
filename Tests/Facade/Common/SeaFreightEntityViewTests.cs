using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class SeaFreightEntityViewTests : AbstractClassTests<SeaFreightEntityView, DefinedEntityView>

    {
        private class testClass : SeaFreightEntityView { }

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

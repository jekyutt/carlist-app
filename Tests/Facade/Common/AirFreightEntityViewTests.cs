using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class AirFreightEntityViewTests : AbstractClassTests<AirFreightEntityView, DefinedEntityView>
    {
        private class testClass : AirFreightEntityView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void TypeOfCargoTest()
        {
            isNullableProperty(() => obj.TypeOfCargo, x => obj.TypeOfCargo = x);
        }
        [TestMethod]
        public void AirplaneTypeTest()
        {
            isNullableProperty(() => obj.AirplaneType, x => obj.AirplaneType = x);
        }

    }
}

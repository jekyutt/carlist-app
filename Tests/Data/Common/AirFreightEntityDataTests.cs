using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;


namespace SemestriProject.Tests.Data.Common
{
    [TestClass]
    public class AirFreightEntityDataTests : AbstractClassTests<AirFreightEntityData, DefinedEntityData>
    {
        private class testClass : AirFreightEntityData { }

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

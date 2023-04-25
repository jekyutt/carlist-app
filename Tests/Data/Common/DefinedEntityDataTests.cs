using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;

namespace SemestriProject.Tests.Data.Common
{

    [TestClass]
    public class DefinedEntityDataTests : AbstractClassTests<DefinedEntityData, NamedEntityData>
    {
        private class testClass : DefinedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void TravelTimeTest()
        {
            isNullableProperty(() => obj.TravelTime, x => obj.TravelTime = x);
        }

        [TestMethod]
        public void OrderTimeTest()
        {
            isNullableProperty(() => obj.OrderTime, x => obj.OrderTime = x);
        }
    }

}


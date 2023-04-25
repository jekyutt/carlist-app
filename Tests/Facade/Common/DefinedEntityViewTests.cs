using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class DefinedEntityViewTests : AbstractClassTests<DefinedEntityView, NamedEntityView>
    {
        private class testClass : DefinedEntityView { }

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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;
using SemestriProject.Tests;

namespace Tests.Data.Common
{
    [TestClass]
    public class PeriodDataTests : AbstractClassTests<PeriodData, object>
    {
        private class testClass : PeriodData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }
        [TestMethod]
        public void ReadyForCollectionTest()
        {
            isNullableProperty(() => obj.ReadyForCollection, x => obj.ReadyForCollection = x);
        }
        [TestMethod]
        public void RequestedDeliveryTimeTest()
        {
            isNullableProperty(() => obj.RequestedDeliveryTime, x => obj.RequestedDeliveryTime = x);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class PeriodViewTests : AbstractClassTests<PeriodView, object>

    {
    private class testClass : PeriodView
    {
    }

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

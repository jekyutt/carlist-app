using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class RoadFreightEntityViewTests : AbstractClassTests<RoadFreightEntityView, DefinedEntityView>
    {

    private class testClass : RoadFreightEntityView { }

    [TestInitialize]
    public override void TestInitialize()
    {
        base.TestInitialize();
        obj = new testClass();
    }

    [TestMethod]
    public void LoadingTest()
    {
        isNullableProperty(() => obj.Loading, x => obj.Loading = x);
    }

    [TestMethod]
    public void DeparturesTest()
    {
        isNullableProperty(() => obj.Departures, x => obj.Departures = x);
    }
    }
}

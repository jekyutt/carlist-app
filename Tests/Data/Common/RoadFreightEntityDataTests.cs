using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;

namespace SemestriProject.Tests.Data.Common
{
    [TestClass]
    public class RoadFreightEntityDataTests : AbstractClassTests<RoadFreightEntityData, DefinedEntityData>
    {
        private class testClass : RoadFreightEntityData { }

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

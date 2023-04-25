using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;

namespace SemestriProject.Tests.Facade.RoadFreight
{
    [TestClass]
    public class RussiaAndCISViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(RussiaAndCISViewFactory);
        }

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<RussiaAndCISView>();
            var data = RussiaAndCISViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<RussiaAndCISData>();
            var view = RussiaAndCISViewFactory.Create(new RussiaAndCIS(data));

            testArePropertyValuesEqual(view, data);
        }
    }
}

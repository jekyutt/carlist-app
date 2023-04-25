using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;

namespace SemestriProject.Tests.Facade.RoadFreight
{
    [TestClass]
    public class ScandinaviaViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(ScandinaviaViewFactory);
        }

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<ScandinaviaView>();
            var data = ScandinaviaViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<ScandinaviaData>();
            var view = ScandinaviaViewFactory.Create(new Scandinavia(data));

            testArePropertyValuesEqual(view, data);
        }
    }
}

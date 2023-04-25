using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Facade.SeaFreight;

namespace SemestriProject.Tests.Facade.SeaFreight
{
    [TestClass]
    public class AfricaViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(AfricaViewFactory);
        }

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AfricaView>();
            var data = AfricaViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AfricaData>();
            var view = AfricaViewFactory.Create(new Africa(data));

            testArePropertyValuesEqual(view, data);
        }
    }
}

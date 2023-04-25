using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;

namespace SemestriProject.Tests.Facade.AirFreight
{
    [TestClass]
    public class AmericaViewFactoryTests : BaseTests
    {
         [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(AmericaViewFactory);
        }

        [TestMethod]
        public void CreateTest()
        {
        }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AmericaView>();
            var data = AmericaViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AmericaData>();
            var view = AmericaViewFactory.Create(new America(data));

            testArePropertyValuesEqual(view, data);
        }
    }
}

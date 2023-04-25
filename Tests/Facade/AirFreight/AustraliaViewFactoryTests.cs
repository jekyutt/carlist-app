using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;

namespace SemestriProject.Tests.Facade.AirFreight
{
    [TestClass]
    public class AustraliaViewFactoryTests : BaseTests
    {

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(AustraliaViewFactory);
        }

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AustraliaView>();
            var data = AustraliaViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AustraliaData>();
            var view = AustraliaViewFactory.Create(new Australia(data));

            testArePropertyValuesEqual(view, data);
        }
    }
}

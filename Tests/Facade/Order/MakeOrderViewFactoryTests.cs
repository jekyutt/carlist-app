using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.Order;
using SemestriProject.Domain.Order;
using SemestriProject.Facade.Order;

namespace SemestriProject.Tests.Facade.Order
{
    [TestClass]
    public class MakeOrderViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(MakeOrderViewFactory);
        }

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<MakeOrderView>();
            var data = MakeOrderViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<MakeOrderData>();
            var view = MakeOrderViewFactory.Create(new MakeOrder(data));

            testArePropertyValuesEqual(view, data);
        }
    }
}

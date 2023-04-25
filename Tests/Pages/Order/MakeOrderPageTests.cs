using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.Order;
using SemestriProject.Domain.Order;
using SemestriProject.Facade.Order;
using SemestriProject.Pages.Common;
using SemestriProject.Pages.Order;

namespace SemestriProject.Tests.Pages.Order
{
    [TestClass]
    public class MakeOrderPageTests : AbstractClassTests<MakeOrderPage,
        BasePage<IMakeOrderRepository, MakeOrder, MakeOrderView, MakeOrderData>>
    {
        private class TestClass : MakeOrderPage
        {
            internal TestClass(IMakeOrderRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<MakeOrder, MakeOrderData>, IMakeOrderRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            obj = new TestClass(r);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<MakeOrderView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/Order/MakeOrder", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/Order/MakeOrder", obj.getPageUrl());


        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<MakeOrderView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<MakeOrderData>();
            var view = obj.toView(new MakeOrder(d));
            testArePropertyValuesEqual(view, d);
        }

    }
}

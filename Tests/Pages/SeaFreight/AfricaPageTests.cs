using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.SeaFreight;
using SemestriProject.Domain.SeaFreight;
using SemestriProject.Facade.SeaFreight;
using SemestriProject.Pages.Common;
using SemestriProject.Pages.SeaFreight;

namespace SemestriProject.Tests.Pages.SeaFreight
{
    [TestClass]
    public class AfricaPageTests : AbstractClassTests<AfricaPage,
        BasePage<IAfricaRepository, Africa, AfricaView, AfricaData>>
    {
        private class TestClass : AfricaPage { internal TestClass(IAfricaRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<Africa, AfricaData>, IAfricaRepository { }

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
            var item = GetRandom.Object<AfricaView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/SeaFreight/Africa", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/SeaFreight/Africa", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AfricaView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<AfricaData>();
            var view = obj.toView(new Africa(d));
            testArePropertyValuesEqual(view, d);
        }
    }
}

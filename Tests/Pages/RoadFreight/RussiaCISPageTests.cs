using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.RoadFreight;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Facade.RoadFreight;
using SemestriProject.Pages.Common;
using SemestriProject.Pages.RoadFreight;

namespace SemestriProject.Tests.Pages.RoadFreight
{
    [TestClass]
    public class RussiaCISPageTests : AbstractClassTests<RussiaCISPage,
        BasePage<IRussiaCISRepository, RussiaAndCIS, RussiaAndCISView, RussiaAndCISData>>
    {
        private class TestClass : RussiaCISPage { internal TestClass(IRussiaCISRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<RussiaAndCIS, RussiaAndCISData>, IRussiaCISRepository { }

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
            var item = GetRandom.Object<RussiaAndCISView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/RoadFreight/RussiaAndCIS", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/RoadFreight/RussiaAndCIS", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<RussiaAndCISView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<RussiaAndCISData>();
            var view = obj.toView(new RussiaAndCIS(d));
            testArePropertyValuesEqual(view, d);
        }


    }
}

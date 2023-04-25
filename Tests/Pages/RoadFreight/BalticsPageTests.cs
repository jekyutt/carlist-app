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
    public class BalticsPageTests : AbstractClassTests<BalticsPage,
        BasePage<IBalticsRepository, Baltic, BalticView, BalticData>>
    {
        private class TestClass : BalticsPage { internal TestClass(IBalticsRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<Baltic, BalticData>, IBalticsRepository { }

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
            var item = GetRandom.Object<BalticView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/RoadFreight/Baltic", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/RoadFreight/Baltic", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<BalticView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<BalticData>();
            var view = obj.toView(new Baltic(d));
            testArePropertyValuesEqual(view, d);
        }


    }
}

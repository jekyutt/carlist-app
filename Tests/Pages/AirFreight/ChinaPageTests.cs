using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Tests.Pages.AirFreight
{
    [TestClass]
    public class ChinaPageTests : AbstractClassTests<ChinaPage,
        BasePage<IChinaRepository, China, ChinaView, ChinaData>>
    {
        private class TestClass : ChinaPage { internal TestClass(IChinaRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<China, ChinaData>, IChinaRepository { }

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
            var item = GetRandom.Object<ChinaView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/AirFreight/China", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/AirFreight/China", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<ChinaView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<ChinaData>();
            var view = obj.toView(new China(d));
            testArePropertyValuesEqual(view, d);
        }


    }
}

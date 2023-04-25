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
    public class EuropePageTests : AbstractClassTests<EuropePage,
        BasePage<IEuropeRepository, Europe, EuropeView, EuropeData>>
    {
        private class TestClass : EuropePage { internal TestClass(IEuropeRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<Europe, EuropeData>, IEuropeRepository { }

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
            var item = GetRandom.Object<EuropeView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/SeaFreight/Europe", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/SeaFreight/Europe", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<EuropeView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<EuropeData>();
            var view = obj.toView(new Europe(d));
            testArePropertyValuesEqual(view, d);
        }
    }
}

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
    public class AmericaPageTests : AbstractClassTests<AmericaPage,
        BasePage<IAmericaRepository, America, AmericaView, AmericaData>>
    {
        private class TestClass : AmericaPage { internal TestClass(IAmericaRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<America, AmericaData>, IAmericaRepository { }

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
            var item = GetRandom.Object<AmericaView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/AirFreight/America", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/AirFreight/America", obj.getPageUrl());
        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AmericaView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<AmericaData>();
            var view = obj.toView(new America(d));
            testArePropertyValuesEqual(view, d);
        }




    }
}

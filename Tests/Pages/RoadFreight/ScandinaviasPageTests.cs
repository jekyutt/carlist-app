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
    public class ScandinaviasPageTests : AbstractClassTests<ScandinaviasPage,
        BasePage<IScandinaviasRepository, Scandinavia, ScandinaviaView, ScandinaviaData>>
    {
        private class TestClass : ScandinaviasPage { internal TestClass(IScandinaviasRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<Scandinavia, ScandinaviaData>, IScandinaviasRepository { }

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
            var item = GetRandom.Object<ScandinaviaView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/RoadFreight/Scandinavia", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/RoadFreight/Scandinavia", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<ScandinaviaView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<ScandinaviaData>();
            var view = obj.toView(new Scandinavia(d));
            testArePropertyValuesEqual(view, d);
        }

    }
}

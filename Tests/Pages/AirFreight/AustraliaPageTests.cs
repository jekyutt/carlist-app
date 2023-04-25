using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Data.Common;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Tests.Pages.AirFreight
{
    [TestClass]
    public class AustraliaPageTests : AbstractClassTests<AustraliaPage,
        BasePage<IAustraliaRepository, Australia, AustraliaView, AustraliaData>>
    {
        private class TestClass : AustraliaPage { internal TestClass(IAustraliaRepository r) : base(r) { } }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<Australia, AustraliaData>, IAustraliaRepository { }
        
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
            var item = GetRandom.Object<AustraliaView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/AirFreight/Australia", obj.PageUrl);

        [TestMethod]
        public void getPageUrlTest() => Assert.AreEqual("/AirFreight/Australia", obj.getPageUrl());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AustraliaView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<AustraliaData>();
            var view = obj.toView(new Australia(d));
            testArePropertyValuesEqual(view, d);
        }




    }
}

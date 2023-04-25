using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Facade.AirFreight;
using SemestriProject.Pages.Common;

namespace SemestriProject.Tests.Pages.Common
{
    [TestClass]
    public class BasePageTests : AbstractPageTests<BasePage<IAmericaRepository, America, AmericaView, AmericaData>,
        PageModel>
    {
        private string fixedFilter;
        private string fixedValue;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass(db);
        }

        [TestMethod]
        public void FixedValueTest()
        {
            var s = GetRandom.String();
            obj.FixedValue = s;
            Assert.AreEqual(s, db.FixedValue);
            Assert.AreEqual(s, obj.FixedValue);
        }

        [TestMethod]
        public void PageUrlTest()
        {
            isReadOnlyProperty(obj, nameof(obj.PageUrl), obj.getPageUrl());
        }
        [TestMethod]
        public void GetPageUrlTest()
        {
            Assert.AreEqual(obj.PageUrl, obj.getPageUrl());
        }
        [TestMethod]
        public void FixedFilterTest()
        {
            var s = GetRandom.String();
            obj.FixedFilter = s;
            Assert.AreEqual(s, db.FixedFilter);
            Assert.AreEqual(s, obj.FixedFilter);
        }

        [TestMethod]
        public void SetFixedFilterTest()
        {
            var filter = GetRandom.String();
            var value = GetRandom.String();
            obj.setFixedFilter(filter, value);
            Assert.AreEqual(filter, obj.FixedFilter);
            Assert.AreEqual(value, obj.FixedValue);
        }

        [TestMethod]
        public void SortOrderTest()
        {
            var s = GetRandom.String();
            obj.SortOrder = s;
            Assert.AreEqual(s, db.SortOrder);
            Assert.AreEqual(s, obj.SortOrder);
        }

        [TestMethod]
        public void AddObjectTest()
        {
            var idx = db.list.Count;
            obj.Item = GetRandom.Object<AmericaView>();
            obj.addObject(fixedFilter, fixedValue).GetAwaiter();
            Assert.AreEqual(fixedFilter, obj.FixedFilter);
            Assert.AreEqual(fixedValue, obj.FixedValue);
            testArePropertyValuesEqual(obj.Item, db.list[idx].Data);
        }
        [TestMethod]
        public void ToObjectTest()
        {
            var v = GetRandom.Object<AmericaView>();
            var o = obj.toObject(v);
            testArePropertyValuesEqual(v, o.Data);
        }
        [TestMethod]
        public void UpdateObjectTest()
        {
            GetObjectTest();
            var idx = GetRandom.Int32(0, db.list.Count);
            var itemId = db.list[idx].Data.Id;
            obj.Item = GetRandom.Object<AmericaView>();
            obj.Item.Id = itemId;
            obj.updateObject(fixedFilter, fixedValue).GetAwaiter();
            testArePropertyValuesEqual(db.list[^1].Data, obj.Item);
        }
        [TestMethod]
        public void GetObjectTest()
        {
            var count = GetRandom.UInt8(5, 10);
            var idx = GetRandom.UInt8(0, count);
            for (var i = 0; i < count; i++) AddObjectTest();
            var item = db.list[idx];
            obj.getObject(item.Data.Id, fixedFilter, fixedValue).GetAwaiter();
            Assert.AreEqual(count, db.list.Count);
            testArePropertyValuesEqual(item.Data, obj.Item);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<AmericaData>();
            var v = obj.toView(new America(d));
            testArePropertyValuesEqual(d, v);
        }

        [TestMethod]
        public void DeleteObjectTest()
        {
            AddObjectTest();
            obj.deleteObject(obj.Item.Id, fixedFilter, fixedValue).GetAwaiter();
            Assert.AreEqual(fixedFilter, obj.FixedFilter);
            Assert.AreEqual(fixedValue, obj.FixedValue);
            Assert.AreEqual(0, db.list.Count);
        }
        [TestMethod]
        public void GetListTest()
        {
            Assert.IsNull(obj.Items);
            var sortOrder = GetRandom.String();
            var currentFilter = GetRandom.String();
            var searchString = GetRandom.String();
            var fixedFilter = GetRandom.String();
            var fixedValue = GetRandom.String();
            var pageIndex = GetRandom.UInt8();
            obj.getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue).GetAwaiter();
            Assert.IsNotNull(obj.Items);
            Assert.AreEqual(sortOrder, obj.SortOrder);
            Assert.AreEqual(searchString, obj.SearchString);
            Assert.AreEqual(fixedFilter, obj.FixedFilter);
            Assert.AreEqual(fixedValue, obj.FixedValue);
            Assert.AreEqual(1, obj.PageIndex);
        }

        [TestMethod]
        public void GetSearchStringTest()
        {
            void test(string filter, string searchString, int? pageIndex, bool isFirst)
            {
                var expectedSearchString = isFirst ? searchString : filter;
                var expectedIndex = isFirst ? 1 : pageIndex;
                var actual = BasePage<IAmericaRepository, America, AmericaView, AmericaData>.getSearchString(filter, searchString, ref pageIndex);
                Assert.AreEqual(expectedSearchString, actual);
                Assert.AreEqual(expectedIndex, pageIndex);
            }
            test(GetRandom.String(), GetRandom.String(), GetRandom.UInt8(3), true);
            test(GetRandom.String(), null, GetRandom.UInt8(3), false);
        }
    }
}

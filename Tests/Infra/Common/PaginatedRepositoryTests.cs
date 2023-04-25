using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.AirFreight;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Common;

namespace SemestriProject.Tests.Infra.Common
{
    [TestClass]
    public class PaginatedRepositoryTests : AbstractClassTests<PaginatedRepository<America, AmericaData>,
        FilteredRepository<America, AmericaData>>
    {
        private class testClass : PaginatedRepository<America, AmericaData>
        {

            public testClass(DbContext c, DbSet<AmericaData> s) : base(c, s) { }

            public override America toDomainObjects(AmericaData d) => new America(d);

            protected override async Task<AmericaData> getData(string id) => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

            protected override string getId(America entity) => entity?.Data?.Id;

        }

        private byte count;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();

            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new AirFreightDbContext(options);
            obj = new testClass(c, c.America);
            count = GetRandom.UInt8(20, 40);
            foreach (var p in c.America)
                c.Entry(p).State = EntityState.Deleted;
            addItems();
        }
        [TestMethod]
        public void PageIndexTest()
        {
            isProperty(() => obj.PageIndex, x => obj.PageIndex = x);
        }

        [TestMethod]
        public void TotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.TotalPages;
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void HasNextPageTest()
        {
            void testNextPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasNextPage;
                Assert.AreEqual(expected, actual);
            }
            testNextPage(0, true);
            testNextPage(1, true);
            testNextPage(GetRandom.Int32(2, obj.TotalPages - 1), true);
            testNextPage(obj.TotalPages, false);
        }

        [TestMethod]
        public void HasPreviousPageTest()
        {
            void testPreviousPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasPreviousPage;
                Assert.AreEqual(expected, actual);
            }
            testPreviousPage(0, false);
            testPreviousPage(1, false);
            testPreviousPage(2, true);
            testPreviousPage(GetRandom.Int32(2, obj.TotalPages), true);
            testPreviousPage(obj.TotalPages, true);
        }

        [TestMethod]
        public void PageSizeTest()
        {
            Assert.AreEqual(25, obj.PageSize);
            isProperty(() => obj.PageSize, x => obj.PageSize = x);
        }

        [TestMethod]
        public void getTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.getTotalPages(obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void countTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.countTotalPages(count, obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void getItemsCountTest()
        {
            var itemsCount = obj.getItemsCount();
            Assert.AreEqual(count, itemsCount);
        }

        private void addItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(new America(GetRandom.Object<AmericaData>())).GetAwaiter();
        }

        [TestMethod]
        public void createSqlQueryTest()
        {
            var o = obj.createSqlQuery();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void addSkipAndTakeTest()
        {
            var sql = obj.createSqlQuery();
            var o = obj.addSkipAndTake(sql);
            Assert.IsNotNull(o);
        }
    }
}

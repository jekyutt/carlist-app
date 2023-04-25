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
    public class BaseRepositoryTests : AbstractClassTests<BaseRepository<America, AmericaData>, object>
    {
        private AmericaData data;

        private class TestClass : BaseRepository<America, AmericaData>
        {

            public TestClass(DbContext c, DbSet<AmericaData> s) : base(c, s) { }

            public override America toDomainObjects(AmericaData d) => new America(d);

            protected override async Task<AmericaData> getData(string id)
            {
                return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
            }

            protected override string getId(America entity) => entity?.Data?.Id;

        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<AirFreightDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new AirFreightDbContext(options);
            obj = new TestClass(c, c.America);
            data = GetRandom.Object<AmericaData>();
        }

       
        public void GetTest()
        {
            var count = GetRandom.UInt8(15, 30);
            var countBefore = obj.Get().GetAwaiter().GetResult().Count;
            for (var i = 0; i < count; i++)
            {
                data = GetRandom.Object<AmericaData>();
                AddTest();
            }
            Assert.AreEqual(count + countBefore, obj.Get().GetAwaiter().GetResult().Count);
        }

        [TestMethod]
        public void GetByIdTest() => AddTest();

        [TestMethod]
        public void toDomainObjectsTest() { }

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            testArePropertyValuesEqual(data, expected.Data);
            obj.Delete(data.Id).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
        }

        [TestMethod]
        public void AddTest()
        {
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
            obj.Add(new America(data)).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            testArePropertyValuesEqual(data, expected.Data);
        }

        [TestMethod]
        public void UpdateTest()
        {
            AddTest();
            var newData = GetRandom.Object<AmericaData>();
            newData.Id = data.Id;
            obj.Update(new America(newData)).GetAwaiter();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            testArePropertyValuesEqual(newData, expected.Data);
        }


    }
}

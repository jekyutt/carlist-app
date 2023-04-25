using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Aids.Random;
using SemestriProject.Data.AirFreight;
using SemestriProject.Domain.Common;

namespace SemestriProject.Tests.Domain.Common
{
    [TestClass]
    public class EntityTests : AbstractClassTests<Entity<AmericaData>, object>
    {
        private class TestClass : Entity<AmericaData>
        {
            public TestClass(AmericaData d = null) : base(d) { }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void DataTest()
        {
            var d = GetRandom.Object<AmericaData>();
            Assert.AreNotSame(d, obj.Data);
            obj = new TestClass(d);
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod]
        public void DataIsNullTest()
        {
            var d = GetRandom.Object<AmericaData>();
            Assert.IsNotNull(obj.Data);
            obj.Data = d;
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod]
        public void CanSetNullDataTest()
        {
            obj.Data = null;
            Assert.IsNull(obj.Data);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Data.Common;

namespace SemestriProject.Tests.Data.Common
{
    [TestClass]
    public class NamedEntityDataTests : AbstractClassTests<NamedEntityData, UniqueEntityData>
    {
        private class testClass : NamedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }
        [TestMethod]
        public void DirectionTest()
        {
            isNullableProperty(() => obj.Direction, x => obj.Direction = x);
        }
    }
}

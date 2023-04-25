using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class NamedEntityViewTests : AbstractClassTests<NamedEntityView, UniqueEntityView>
    {
        private class testClass : NamedEntityView { }

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

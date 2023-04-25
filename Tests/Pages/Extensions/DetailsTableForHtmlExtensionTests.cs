using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Pages.Extensions;

namespace SemestriProject.Tests.Pages.Extensions
{
    [TestClass]
    public class DetailsTableForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(DetailsTableForHtmlExtension);

       [TestMethod]
        public void DetailsTableForTest()
        {
            Assert.Inconclusive();
        }
    }
}

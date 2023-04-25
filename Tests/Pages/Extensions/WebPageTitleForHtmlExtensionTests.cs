using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Pages.Extensions;

namespace SemestriProject.Tests.Pages.Extensions
{
    [TestClass]
    public class WebPageTitleForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(WebPageTitleForHtmlExtension);

        [TestMethod]
        public void WebPageTitleForTest()
        {
            Assert.Inconclusive();
        }
    }
}
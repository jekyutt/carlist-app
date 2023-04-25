using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Pages.Extensions;

namespace SemestriProject.Tests.Pages.Extensions
{
    [TestClass]
    public class DisplayControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(DisplayControlsForHtmlExtension);

        [TestMethod]
        public void DisplayControlsForTest()
        {
            Assert.Inconclusive();
        }
    }
}

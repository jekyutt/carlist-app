using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Pages.Extensions;

namespace SemestriProject.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(TableRowForHtmlExtension);

        [TestMethod]
        public void TableRowForTest() => Assert.Inconclusive();

        [TestMethod]
        public void TableRowWithSelectForTest() => Assert.Inconclusive();
    }
}
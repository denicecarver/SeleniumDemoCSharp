using Microsoft.VisualStudio.TestTools.UnitTesting;

using Resources = SeleniumDemoTests.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage.Tests
{
    [TestClass()]
    public class SearchFormTests
    {

        #region private members
        //global for the test run
        private static TestContext context;
        private static HomePage homePage = new HomePage();
        #endregion

        #region Initialisation and cleanup
        /// <summary>
        /// Executes once before the test-suite
        /// </summary>
        [ClassInitialize]
        public static void setup(TestContext testContext)
        {
            context = testContext;
            homePage.goToWikiHomePage();
        }

        /// <summary>
        /// Executes once at the end of the test-suite
        /// </summary>
        [ClassCleanup]
        public static void teardown()
        {
            homePage.closeBrowser();
        }

        [TestCleanup]
        public void resetForNextTest()
        {
            homePage.goToWikiHomePage();
        }
        #endregion

        [TestMethod]
        public void searchForExistingTerm()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void searchForRedirectTerm()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void searchForBlankTerm()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void searchForLeftCurlyBracket()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void searchForOutOfBoundsTerm()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void searchForTooLongTerm()
        {
            // Enter term that exceeds length limit into field

            // Click go button
            // Get URL at search result page
            // Compare with expected value
            Assert.Fail();
        }

    }
}
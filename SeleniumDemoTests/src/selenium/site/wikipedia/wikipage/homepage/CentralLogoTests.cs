using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.selenium.wikitest.wikipage.homepage.Tests
{
    [TestClass()]
    public class CentralLogoTests
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
            homePage.openPage();
        }
        #endregion

        [TestMethod]
        public void isCentralLogoFound()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void isEnglishFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.English));
        }

        [TestMethod]
        public void isSpanishFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Spanish));
        }

        [TestMethod]
        public void isJapanesFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Japanese));
        }

        [TestMethod]
        public void isRussianFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Russian));
        }

        [TestMethod]
        public void isFrenchFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.French));
        }

        [TestMethod]
        public void isGermanFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.German));
        }

        [TestMethod]
        public void isItalianFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Italian));
        }

        [TestMethod]
        public void isChineseFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Chinese));
        }

        [TestMethod]
        public void isPolishFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Polish));
        }

        [TestMethod]
        public void isPortugueseFound()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Portuguese));
        }

        [ClassCleanup]
        public static void teardown()
        {
            homePage.closeBrowser();
        }

    }
}

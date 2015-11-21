using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.selenium.wikitest.wikipage.homepage.Tests
{
    [TestClass()]
    public class IsLanguageDisplayed
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
        public void isEnglishDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.English));
        }

        [TestMethod]
        public void isSpanishDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Spanish));
        }

        [TestMethod]
        public void isJapanesDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Japanese));
        }

        [TestMethod]
        public void isRussianDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Russian));
        }

        [TestMethod]
        public void isFrenchDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.French));
        }

        [TestMethod]
        public void isGermanDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.German));
        }

        [TestMethod]
        public void isItalianDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Italian));
        }

        [TestMethod]
        public void isChineseDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Chinese));
        }

        [TestMethod]
        public void isPolishDisplayed()
        {
            Assert.IsTrue(homePage.isLanguageFound(HomePage.Language.Polish));
        }

        [TestMethod]
        public void isPortugueseDisplayed()
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

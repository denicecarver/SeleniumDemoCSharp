using Microsoft.VisualStudio.TestTools.UnitTesting;

using Language = selenium.site.wikipedia.languages.LanguageData.Language;

using shared;

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

        #region Central Logo Items Exist Testing
        [TestMethod]
        public void isWikipediaLogoFound()
        {
            // Is found if the logo element with title attribute 'Wikipedia' is found
            Assert.IsNotNull(homePage.getCentralLogoTitle());
        }

        [TestMethod]
        public void isEnglishLinkFound()
        {
            // Is found if the English link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.English));
        }

        [TestMethod]
        public void isSpanishLinkFound()
        {
            // Is found if the Spanish link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Spanish));
        }

        [TestMethod]
        public void isJapanesLinkFound()
        {
            // Is found if the Japanese link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Japanese));
        }

        [TestMethod]
        public void isRussianLinkFound()
        {
            // Is found if the Russian link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Russian));
        }

        [TestMethod]
        public void isFrenchLinkFound()
        {
            // Is found if the French link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.French));
        }

        [TestMethod]
        public void isGermanLinkFound()
        {
            // Is found if the German link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.German));
        }

        [TestMethod]
        public void isItalianLinkFound()
        {
            // Is found if the Italian link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Italian));
        }

        [TestMethod]
        public void isChineseLinkFound()
        {
            // Is found if the Chinese link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Chinese));
        }

        [TestMethod]
        public void isPolishLinkFound()
        {
            // Is found if the Polish link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Polish));
        }

        [TestMethod]
        public void isPortugueseLinkFound()
        {
            // Is found if the Portuguese link is returned
            Assert.IsNotNull(homePage.getCentralLogoLanguageLink(Language.Portuguese));
        }
        #endregion

        #region Central Logo Links Testing
        [TestMethod]
        public void goesToEnglishWikiFromCentralLogoLink()
        {
            // Click on the English link
            homePage.getCentralLogoLanguageLink(Language.English).Click();

            // Get the actual URL of clicking on the English link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the English link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.English);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPolishWikiFromCentralLogo()
        {
            // Click on the Polish link
            homePage.getCentralLogoLanguageLink(Language.Polish).Click();

            // Get the actual URL of clicking on the Polish link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Polish link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Polish);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToFrenchWikiFromCentralLogo()
        {
            // Click on the French link
            homePage.getCentralLogoLanguageLink(Language.French).Click();

            // Get the actual URL of clicking on the French link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the French link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.French);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToGermanWikiFromCentralLogo()
        {
            // Click on the German link
            homePage.getCentralLogoLanguageLink(Language.German).Click();

            // Get the actual URL of clicking on the German link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the German link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.German);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToItalianWikiFromCentralLogo()
        {
            // Click on the Italian link
            homePage.getCentralLogoLanguageLink(Language.Italian).Click();

            // Get the actual URL of clicking on the Italian link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Italian link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Italian);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToJapaneseWikiFromCentralLogo()
        {
            // Click on the Japanese link
            homePage.getCentralLogoLanguageLink(Language.Japanese).Click();

            // Get the actual URL of clicking on the Japanese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Japanese link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Japanese);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToChineseWikiFromCentralLogoLink()
        {
            // Click on the Chinese link
            homePage.getCentralLogoLanguageLink(Language.Chinese).Click();

            // Get the actual URL of clicking on the Chinese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Chinese link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Chinese);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToRussianWikiFromCentralLogoLink()
        {
            // Click on the Russian link
            homePage.getCentralLogoLanguageLink(Language.Russian).Click();

            // Get the actual URL of clicking on the Russian link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Russian link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Russian);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPortugueseWikiFromCentralLogoLink()
        {
            // Click on the Portuguese link
            homePage.getCentralLogoLanguageLink(Language.Portuguese).Click();

            // Get the actual URL of clicking on the Portuguese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Portuguese link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Portuguese);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToSpanishWikiFromCentralLogoLink()
        {
            // Click on the Spanish link
            homePage.getCentralLogoLanguageLink(Language.Spanish).Click();

            // Get the actual URL of clicking on the Spanish link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL of the Spanish link
            string expectedResult = HomePageTestData.getLanguageHomepageUrl(Language.Spanish);

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }
        #endregion

    }
}

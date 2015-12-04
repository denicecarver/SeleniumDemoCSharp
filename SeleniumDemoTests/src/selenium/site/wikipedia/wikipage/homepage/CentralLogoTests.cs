using Microsoft.VisualStudio.TestTools.UnitTesting;

using Language = selenium.site.wikipedia.languages.LanguageData.Language;
using HomePageTestResources = SeleniumDemoTests.Properties.Resources;

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
            Assert.IsNotNull(homePage.CentralLogoTitle);
        }

        [TestMethod]
        public void isEnglishLinkFound()
        {
            // Is found if the English link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.English));
        }

        [TestMethod]
        public void isSpanishLinkFound()
        {
            // Is found if the Spanish link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Spanish));
        }

        [TestMethod]
        public void isJapanesLinkFound()
        {
            // Is found if the Japanese link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Japanese));
        }

        [TestMethod]
        public void isRussianLinkFound()
        {
            // Is found if the Russian link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Russian));
        }

        [TestMethod]
        public void isFrenchLinkFound()
        {
            // Is found if the French link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.French));
        }

        [TestMethod]
        public void isGermanLinkFound()
        {
            // Is found if the German link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.German));
        }

        [TestMethod]
        public void isItalianLinkFound()
        {
            // Is found if the Italian link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Italian));
        }

        [TestMethod]
        public void isChineseLinkFound()
        {
            // Is found if the Chinese link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Chinese));
        }

        [TestMethod]
        public void isPolishLinkFound()
        {
            // Is found if the Polish link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Polish));
        }

        [TestMethod]
        public void isPortugueseLinkFound()
        {
            // Is found if the Portuguese link is returned
            Assert.IsNotNull(homePage.CentralLogoLanguageLink(Language.Portuguese));
        }
        #endregion

        #region Central Logo Links Testing
        [TestMethod]
        public void goesToEnglishWikiFromCentralLogoLink()
        {
            // Click on the English link
            homePage.CentralLogoEnglishLink.Click();

            // Get the actual URL after clicking on the English link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the English Wiki Home page
            string expectedResult = HomePageTestResources.HomePageURLEnglish;

            // Compare actual and expected URLs
            // (uses contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPolishWikiFromCentralLogo()
        {
            // Click on the Polish link
            homePage.CentralLogoLanguageLink(Language.Polish).Click();

            // Get the actual URL after clicking on the Polish link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Polish link
            string expectedResult = HomePageTestResources.HomePageURLPolish;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToFrenchWikiFromCentralLogo()
        {
            // Click on the French link
            homePage.CentralLogoLanguageLink(Language.French).Click();

            // Get the actual URL after clicking on the French link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the French link
            string expectedResult = HomePageTestResources.HomePageURLFrench;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToGermanWikiFromCentralLogo()
        {
            // Click on the German link
            homePage.CentralLogoLanguageLink(Language.German).Click();

            // Get the actual URL after clicking on the German link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the German link
            string expectedResult = HomePageTestResources.HomePageURLGerman;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToItalianWikiFromCentralLogo()
        {
            // Click on the Italian link
            homePage.CentralLogoLanguageLink(Language.Italian).Click();

            // Get the actual URL after clicking on the Italian link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Italian link
            string expectedResult = HomePageTestResources.HomePageURLItalian;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToJapaneseWikiFromCentralLogo()
        {
            // Click on the Japanese link
            homePage.CentralLogoLanguageLink(Language.Japanese).Click();

            // Get the actual URL after clicking on the Japanese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Japanese link
            string expectedResult = HomePageTestResources.HomePageURLJapanese;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToChineseWikiFromCentralLogoLink()
        {
            // Click on the Chinese link
            homePage.CentralLogoLanguageLink(Language.Chinese).Click();

            // Get the actual URL after clicking on the Chinese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Chinese link
            string expectedResult = HomePageTestResources.HomePageURLChinese;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToRussianWikiFromCentralLogoLink()
        {
            // Click on the Russian link
            homePage.CentralLogoLanguageLink(Language.Russian).Click();

            // Get the actual URL after clicking on the Russian link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Russian link
            string expectedResult = HomePageTestResources.HomePageURLRussian;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPortugueseWikiFromCentralLogoLink()
        {
            // Click on the Portuguese link
            homePage.CentralLogoLanguageLink(Language.Portuguese).Click();

            // Get the actual URL after clicking on the Portuguese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Portuguese link
            string expectedResult = HomePageTestResources.HomePageURLPortuguese;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToSpanishWikiFromCentralLogoLink()
        {
            // Click on the Spanish link
            homePage.CentralLogoLanguageLink(Language.Spanish).Click();

            // Get the actual URL after clicking on the Spanish link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Spanish link
            string expectedResult = HomePageTestResources.HomePageURLSpanish;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }
        #endregion

    }
}

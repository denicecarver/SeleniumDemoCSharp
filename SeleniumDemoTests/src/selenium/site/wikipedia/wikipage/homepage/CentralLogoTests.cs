using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using selenium.site.wikipedia.languages;
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
        public void isCentralLogoFound()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void isEnglishFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.English));
        }

        [TestMethod]
        public void isSpanishFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Spanish));
        }

        [TestMethod]
        public void isJapanesFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Japanese));
        }

        [TestMethod]
        public void isRussianFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Russian));
        }

        [TestMethod]
        public void isFrenchFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.French));
        }

        [TestMethod]
        public void isGermanFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.German));
        }

        [TestMethod]
        public void isItalianFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Italian));
        }

        [TestMethod]
        public void isChineseFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Chinese));
        }

        [TestMethod]
        public void isPolishFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Polish));
        }

        [TestMethod]
        public void isPortugueseFound()
        {
            Assert.IsTrue(homePage.isCentralLogoLanguageLinkFound(LanguageData.Language.Portuguese));
        }
        #endregion

        #region Central Logo Links Testing
        [TestMethod]
        public void goToEnglishWiki()
        {
            string actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.English);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.English);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToPolishWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Polish);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Polish);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToFrenchWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.French);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.French);
            Assert.IsTrue(actualResult.Contains(expectedResult), CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToGermanWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.German);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.German);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToItalianWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Italian);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Italian);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToJapaneseWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Japanese);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Japanese);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToChineseWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Chinese);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Chinese);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToRussianWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Russian);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Russian);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToPortugueseWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Portuguese);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Portuguese);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToSpanishWiki()
        {
            String actualResult = homePage.clickCentralLogoLanguageLink(LanguageData.Language.Spanish);
            String expectedResult = LanguageData.getLanguageHomepageUrl(LanguageData.Language.Spanish);
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }
        #endregion

    }
}

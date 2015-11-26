using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium.site.wikipedia.languages;
using shared;

namespace com.selenium.wikitest.wikipage.homepage.Tests
{
    [TestClass()]
    public class GoToWikiInLanguage
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
        #endregion

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

        [TestCleanup]
        public void resetForNextTest()
        {
            homePage.goToWikiHomePage();
        }

        [ClassCleanup]
        public static void commonTearDown()
        {
            homePage.closeBrowser();
        }

    }
}

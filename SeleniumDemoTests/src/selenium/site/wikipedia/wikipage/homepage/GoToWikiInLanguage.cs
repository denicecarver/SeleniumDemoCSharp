using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium.site.wikipedia.shared;

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
            homePage.openPage();
        }
        #endregion

        [TestMethod]
        public void goToEnglishWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.English);
            String expectedResult = HomePage.Language.English.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToPolishWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.Polish);
            String expectedResult = HomePage.Language.Polish.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToFrenchWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.French);
            String expectedResult = HomePage.Language.French.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult), CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToGermanWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.German);
            String expectedResult = HomePage.Language.German.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToItalianWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.Italian);
            String expectedResult = HomePage.Language.Italian.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToJapaneseWiki()
        {
            String actualResult = homePage.getJapanesePageTitle();
            String expectedResult = HomePage.Language.Japanese.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToChineseWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.Chinese);
            String expectedResult = HomePage.Language.Chinese.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToRussianWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.Russian);
            String expectedResult = HomePage.Language.Russian.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToPortugueseWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.Portuguese);
            String expectedResult = HomePage.Language.Portuguese.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goToSpanishWiki()
        {
            String actualResult = homePage.goToProjectLink(HomePage.Language.Spanish);
            String expectedResult = HomePage.Language.Spanish.ToString();
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestCleanup]
        public void resetForNextTest()
        {
            homePage.openHomePage();
        }

        [ClassCleanup]
        public static void commonTearDown()
        {
            homePage.closeBrowser();
        }

    }
}

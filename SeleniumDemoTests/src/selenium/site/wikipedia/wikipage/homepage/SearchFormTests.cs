using Microsoft.VisualStudio.TestTools.UnitTesting;
using shared;
using TestDataResources = SeleniumDemoTests.Properties.Resources;

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
            // Enter an empty string into the Search field to assure the field is blank
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchRedirectTerm);

            // Click go button
            homePage.SearchGoButton.Click();

            // Look for Redirect text
            string actualResult = homePage.ResultsPageRedirectClass.Text.Trim();

            // Get the expected URL for landing on the special page
            string expectedResult = TestDataResources.HomeSearchRedirectText;

            // Compare with expected error msg value
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForBlankTerm()
        {
            // Enter an empty string into the Search field to assure the field is blank
            homePage.SearchTextField.SendKeys("");

            // Click go button
            homePage.SearchGoButton.Click();

            // Get URL at search result page when search term doesn't exist
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for landing on the special page
            string expectedResult = TestDataResources.SpecialPageURL;

            // Compare with expected error msg value
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForLeftCurlyBracket()
        {
            // Enter a left curly bracket into the search field
            string tmpo = TestDataResources.HomeSearchTermLeftCurlyBracket;
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchTermLeftCurlyBracket);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get error msg at search result page
            string actualResult = homePage.SearchResultsHeading.Text;

            // Get the expected search result heading after search
            string expectedResult = TestDataResources.HomeSearchLeftCurlyBracketResult;

            // Compare with expected error msg value
            Assert.AreEqual(actualResult, expectedResult,
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForOutOfBoundsTerm()
        {
            // Enter a term that exceeds the length limit for a URL
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchTermOutOfBounds);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get error msg at search result page
            string actualResult = homePage.ErrorPageTitle.Text;

            // Get the expected search result heading after search
            string expectedResult = TestDataResources.HomeSearchFailureText;

            // Compare with expected error msg value
            Assert.AreEqual(actualResult, expectedResult,
                    CommonMethods.formatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForTooLongTerm()
        {
            // Enter a term that exceeds the length limit for a search item into the search field
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchTermExceedsLengthLimit);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get error msg at search result page
            string actualResult = homePage.ResultsPageErrorMsg.Text;

            // Compare with expected error msg value
            Assert.AreEqual(actualResult, TestDataResources.ErrorMsgExceedsLengthLimit);
        }

    }
}
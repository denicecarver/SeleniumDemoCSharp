using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using selenium.site.wikipedia.languages;

using shared;

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

            // Get text to search
            //String expectedResult = HomePageText.getString("SeleniumPage.SeleniumTitle");

            // Run search from home page and get result
            //String actualResult = homePage.searchFor(expectedResult);

            // Assert expected matches actual
            //try {
            //              assertTrue(CommonMethods.formatAssertMessage(expectedResult, actualResult),
            //                      actualResult.contains(expectedResult));
            //          } catch (AssertionError ae) {
            //              homePage.getUniqueScreenshot(this.toString());
            //              ae.printStackTrace();
            //              throw (ae);
            //          }
        }

        [TestMethod]
        public void searchForRedirectTerm()
        {

            //// Get redirect text
            //String expectedResult = WikiPageText.getString("AnyPage.RedirectText");

            //// Go to redirected page
            //homePage.searchFor(expectedResult);

            //// Get text from non-redirected page
            //String actualResult = homePage.searchForRedirect(expectedResult);

            //// Assert expected matches actual
            //try
            //{
            //    assertTrue(CommonMethods.formatAssertMessage(expectedResult, actualResult),
            //            actualResult.contains(expectedResult));
            //}
            //catch (AssertionError ae)
            //{
            //    homePage.getUniqueScreenshot(this.toString());
            //    ae.printStackTrace();
            //    throw (ae);
            //}

        }

        [TestMethod]
        public void searchForBlankTerm()
        {

  //          // Set expected outcome
  //          String expectedResult = HomePageText.getString("ErrorPage.EmptyStringSearchTitle");

  //          // Run search and get result.
  //          String actualResult = homePage.searchFor(HomePageText.getString("HomePage.EmptyString"));

		//// Assert expected == actual
		//try {
  //              assertTrue(CommonMethods.formatAssertMessage(expectedResult, actualResult),
  //                      actualResult.contains(expectedResult));
  //          } catch (AssertionError ae) {
  //              homePage.getUniqueScreenshot(this.toString());
  //              ae.printStackTrace();
  //              throw (ae);
  //          }
        }

        /*
         * Data-driven test of multi-bit character set 
         */

        [TestMethod]
        public void searchForLeftCurlyBracket()
        {

            // Set expected outcome
  //          String expectedResult = HomePageText.getString("HomePage.OpenBraceSearch");

  //          // Run search and get result
  //          String actualResult = homePage.searchFor(expectedResult);
		
		//// Assert expected matches actual
		//try {
  //              assertTrue(CommonMethods.formatAssertMessage(expectedResult, actualResult),
  //                      actualResult.startsWith(expectedResult));
  //          } catch (AssertionError ae) {
  //              homePage.getUniqueScreenshot(this.toString());
  //              ae.printStackTrace();
  //              throw (ae);
  //          }

        }

        [TestMethod]
        public void searchForOutOfBoundsTerm()
        {

  //          // Set expected outcome
  //          String expectedResult = HomePageText.getString("ErrorPage.SearchErrored");

  //          // Assert fails - bug
  //          homePage.searchFor(HomePageText.getString("ErrorPage.SearchOutOfBoundsString"));
  //          String actualResult = homePage.getSearchResultDetails();
		
		//try {
  //              assertTrue(CommonMethods.formatAssertMessage(expectedResult, actualResult),
  //                      actualResult.contains(expectedResult));
  //          } catch (AssertionError ae) {
  //              homePage.getUniqueScreenshot(this.toString());
  //              ae.printStackTrace();
  //              throw (ae);
  //          }


        }

        [TestMethod]
        public void searchForTooLongTerm()
        {

            // Set expected outcome
            //String expectedResult = HomePageText.getString("ErrorPage.SearchErrored");

  //          // Run search and get result page
  //          homePage.searchFor(HomePageText.getString("ErrorPage.SearchTooLongString"));
  //          String actualResult = homePage.getSearchResultDetails();
		
		//try {
  //              assertTrue(CommonMethods.formatAssertMessage(expectedResult, actualResult),
  //                      actualResult.contains(expectedResult));
  //          } catch (AssertionError ae) {
  //              homePage.getUniqueScreenshot(this.toString());
  //              ae.printStackTrace();
  //              throw (ae);
  //          }

        }

    }
}
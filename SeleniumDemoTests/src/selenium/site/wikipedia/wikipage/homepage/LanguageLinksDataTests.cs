using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Data;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using shared;
using System.Data.SQLite;

namespace selenium.site.wikipedia.wikipage.homepage.Tests
{
    /// <summary>
    /// Summary description for LanguageLinksDataTests
    /// </summary>
    [TestClass]
    public class LanguageLinksDataTests
    {
        public LanguageLinksDataTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region private members
        //global for the test run
        private static TestContext testContextInstance;
        private static HomePage homePage = new HomePage(CommonMethods.webDriver);
        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Initialisation and cleanup
        [ClassInitialize]
        public static void setup(TestContext testContext)
        {
            testContextInstance = testContext;
        }

        [TestInitialize]
        public void setForNextTest()
        {
            homePage.goToWikiHomePage();
        }

        [ClassCleanup]
        public static void teardown()
        {
            homePage.closeBrowser();
        }
        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void getLanguageLinks()
        {

            ReadOnlyCollection<IWebElement> weListPrimary = homePage.getElementsByXPath(".//*[@id='www-wikipedia-org']/div/ul/li/a");
            ReadOnlyCollection<IWebElement> weListSecondary = homePage.getElementsByXPath(".//*[@id='www-wikipedia-org']/div/ul/li/a/span");
            ReadOnlyCollection<IWebElement> weListTertiary = homePage.getElementsByXPath(".//*[@id='www-wikipedia-org']/div/ul/li/a/bdi");
            CommonMethods.LoadLanguageLinkData(weListPrimary);
            CommonMethods.LoadLanguageLinkData(weListSecondary);
            CommonMethods.LoadLanguageLinkData(weListTertiary);
        }
    }
}

using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

using Resources = SeleniumDemo.Properties.Resources;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiPage
    {

        private IWebDriver webDriver = new FirefoxDriver();

        protected const string WikiOrgUrl = "https://www.wikipedia.org/";

        protected void goToUrl()
        {
            goToUrl(WikiOrgUrl);
        }

        protected void goToUrl(string url)
        {
            try
            {
                webDriver.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
        }

        protected IWebElement getElementById(By mechanism)
        {
            return webDriver.FindElement(mechanism);
        }

        protected string getTextByXPath(string elementXPath)
        {
            return getElementById(By.XPath(elementXPath)).Text;
        }

        protected IWebElement getElementByXPath(string elementXPath)
        {
            return getElementById(By.XPath(elementXPath));
        }

        protected IWebElement getElementByID(string elementID)
        {
            return getElementById(By.Id(elementID));
        }

        /// <summary>
        /// Method for test initialization
        /// </summary>
        public void goToWikiHomePage()
        {
            goToUrl();
        }

        /// <summary>
        /// Provides a way for tests to determine current location
        /// </summary>
        /// <returns> string URL</returns>
        public string getCurrentUrl()
        {
            return webDriver.Url;
        }

        public void closeBrowser()
        {
            webDriver.Quit();
        }

    }
}

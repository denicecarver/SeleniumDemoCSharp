using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

using Resources = SeleniumDemo.Properties.Resources;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiPage
    {
        protected const string WikiOrgUrl = "https://www.wikipedia.org/";

        protected IWebDriver webDriver = new FirefoxDriver();

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

        //TODO: Replace hack with viable code, this search must be generic and act from any wikipage throughout the website
        public string searchFor(string searchTerm)
        {
            //TODO: Move XPaths to Properties and have HomePage retrieve them through HomePageData
            getElementByID(Resources.HomeIDSearchFormInputField).SendKeys(searchTerm);
            getElementByXPath(Resources.HomeXPathSearchButton).Click();
            return webDriver.Title;
        }

        /// <summary>
        /// This provides a way to determine current state locate
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

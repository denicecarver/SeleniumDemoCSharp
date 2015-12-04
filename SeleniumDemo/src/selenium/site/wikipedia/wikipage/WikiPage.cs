using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiPage
    {
        private const string wikiOrgUrl = "https://www.wikipedia.org/";

        protected IWebDriver webDriver = new FirefoxDriver();

        protected static string WikiOrgUrl
        {
            get
            {
                return wikiOrgUrl;
            }
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

        protected IWebElement getElement(By mechanism)
        {
            return webDriver.FindElement(mechanism);
        }

        protected string getTextAtXPath(string xpathToElement)
        {
            return getElement(By.XPath(xpathToElement)).Text;
        }

        protected IWebElement getElementAtXPath(string xpathToElement)
        {
            return getElement(By.XPath(xpathToElement));
        }

        public string searchFor(string searchTerm)
        {
            getElement(By.XPath("//*[@id='searchInput']")).SendKeys(searchTerm);
            getElement(By.XPath("//button[@name='go']")).Click();
            return webDriver.Title;
        }

        // Where am I - for dealing with link testing
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

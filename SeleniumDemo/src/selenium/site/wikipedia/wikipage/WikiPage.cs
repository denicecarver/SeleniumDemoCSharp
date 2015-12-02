using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiPage
    {
        private const String wikiOrgUrl = "https://www.wikipedia.org/";

        protected IWebDriver webDriver = new FirefoxDriver();

        protected static string WikiOrgUrl
        {
            get
            {
                return wikiOrgUrl;
            }
        }

        protected void goToUrl(String url)
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

        protected String getTextAtXPath(String xpathToElement)
        {
            return getElement(By.XPath(xpathToElement)).Text;
        }

        protected IWebElement getElementAtXPath(String xpathToElement)
        {
            return getElement(By.XPath(xpathToElement));
        }

        // Where am I - for dealing with link testing
        public String getCurrentUrl()
        {
            return webDriver.Url;
        }


        public void closeBrowser()
        {
            webDriver.Quit();
        }

    }
}

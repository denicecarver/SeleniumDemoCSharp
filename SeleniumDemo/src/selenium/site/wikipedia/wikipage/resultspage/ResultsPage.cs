using OpenQA.Selenium;

using selenium.site.wikipedia.wikipage;

using Resources = SeleniumDemo.Properties.Resources;

namespace com.selenium.wikitest.wikipage.resultspage
{
    public class ResultsPage : WikiPage
    {

        #region Result Page Elements
        public IWebElement ErrorMsg
        {
            get
            {
                return getElementByXPath(Resources.ResultsXPathSpecialError);
            }
        }

        public IWebElement PageRedirectClass
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathSearchRedirectClass);
            }
        }

        public IWebElement ErrorPageTitle
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathSearchFailureTitle);
            }
        }
        #endregion

    }
}

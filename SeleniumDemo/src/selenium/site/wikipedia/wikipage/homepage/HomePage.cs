using OpenQA.Selenium;

using Language = selenium.site.wikipedia.languages.LanguageData.Language;
using selenium.site.wikipedia.wikipage;

using Resources = SeleniumDemo.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage
{
    public class HomePage : WikiPage
    {

        public void goToWikiHomePage()
        {
            goToUrl(WikiOrgUrl);
        }

        #region Central Logo Methods
        public IWebElement getCentralLogoLanguageLink(Language language)
        {
            return getElementByXPath(HomePageData.GetXPathToLanguageLink(language));
        }

        public IWebElement getCentralLogoTitle()
        {
            return getElementByXPath(Resources.HomeXPathCentralLogoTitle);
        }
        #endregion

        #region Search Form Methods
        public IWebElement getSearchTextField()
        {
            return getElementByID(Resources.HomeIDSearchFormInputField);
        }

        public IWebElement getSearchButton()
        {
            return getElementByXPath(Resources.HomeXPathSearchButton);
        }
        #endregion

        #region Result Page Methods
        public IWebElement getErrorMessageElement()
        {
            return getElementByXPath(Resources.ResultsXPathSpecialErrorMsg);
        }
        #endregion
    }
}

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

        #region Search Form Elements
        public IWebElement SearchGoButton
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathSearchButton);
            }

        }

        public IWebElement SearchTextField
        {
            get
            {
                return getElementByID(Resources.HomeIDSearchFormInputField);
            }
        }

        public IWebElement SearchErrorMsgText
        {
            get
            {
                return getElementByXPath(Resources.ResultsXPathSpecialError);
            }
        }
        #endregion

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
        #endregion

        #region Result Page properties
        public IWebElement ResultsPageErrorMsg
        {
            get
            {
                return getElementByXPath(Resources.ResultsXPathSpecialError);
            }
        }
        #endregion
    }
}

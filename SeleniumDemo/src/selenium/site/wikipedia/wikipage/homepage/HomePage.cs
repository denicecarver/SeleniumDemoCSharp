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

        #region Central Logo Elements
        public IWebElement CentralLogoLanguageLink(Language language)
        {
            return getElementByXPath(HomePageData.GetXPathToLanguageLink(language));
        }

        public IWebElement CentralLogoEnglishLink
        {
            get
            {
                return getElementByXPath(HomePageData.GetXPathToLanguageLink(Language.English));
            }
        }

        public IWebElement CentralLogoTitle
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoTitle);
            }
        }
        #endregion

        #region Search Form Elements
        #endregion

        #region Result Page Elements
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

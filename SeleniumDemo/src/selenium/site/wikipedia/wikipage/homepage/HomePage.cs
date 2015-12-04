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

        #region Central Logo
        public IWebElement getCentralLogoLanguageLink(Language language)
        {
            return getElementAtXPath(HomePageData.getLanguageXPath(language));
        }

        public IWebElement getCentralLogoTitle()
        {
            return getElementAtXPath(Resources.HomeXPathCentralLogoTitle);
        }
        #endregion

    }
}

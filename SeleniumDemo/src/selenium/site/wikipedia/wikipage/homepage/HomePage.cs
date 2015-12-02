using OpenQA.Selenium;

using selenium.site.wikipedia.languages;
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
        public IWebElement getCentralLogoLanguageLink(LanguageData.Language language)
        {
            return getElementAtXPath(LanguageData.getLanguageXPath(language));
        }

        public IWebElement getCentralLogoTitle()
        {
            return getElementAtXPath(Resources.HomeXPathCentralLogoTitle);
        }
        #endregion

    }
}

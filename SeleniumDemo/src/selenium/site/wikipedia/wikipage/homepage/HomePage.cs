using OpenQA.Selenium;

using Language = selenium.site.wikipedia.languages.LanguageData.Language;
using selenium.site.wikipedia.wikipage;

using Resources = SeleniumDemo.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage
{
    public class HomePage : WikiPage
    {

        #region Central Logo Elements
        public IWebElement LinkCentralLogoChinese
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoChinese);
            }
        }

        public IWebElement LinkCentralLogoEnglish
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoEnglish);
            }
        }

        public IWebElement LinkCentralLogoFrench
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoFrench);
            }
        }

        public IWebElement LinkCentralLogoGerman
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoGerman);
            }
        }

        public IWebElement LinkCentralLogoItalian
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoItalian);
            }
        }

        public IWebElement LinkCentralLogoJapanese
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoJapanese);
            }
        }

        public IWebElement LinkCentralLogoPolish
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoPolish);
            }
        }

        public IWebElement LinkCentralLogoPortuguese
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoPortuguese);
            }
        }

        public IWebElement LinkCentralLogoRussian
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoRussian);
            }
        }

        public IWebElement LinkCentralLogoSpanish
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoSpanish);
            }
        }

        public IWebElement SearchResultsHeading
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathSearchResultClass);
            }
        }

        public IWebElement TitleCentralLogo
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoTitle);
            }
        }
        #endregion

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
                return getElementByID(Resources.HomeIDSearchFormTextField);
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

    }
}

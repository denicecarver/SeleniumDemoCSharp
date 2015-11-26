using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

using selenium.site.wikipedia.languages;
using selenium.site.wikipedia.wikipage;

namespace com.selenium.wikitest.wikipage.homepage
{
    public class HomePage : WikiPage
    {

        public bool isCentralLogoLanguageLinkFound(LanguageData.Language language)
        {
            String xpath = LanguageData.getLanguageXPath(language);
            return getDisplayedLanguage(LanguageData.getLanguageXPath(language)).StartsWith(LanguageData.getNativeLanguageName(language));
        }

        public string clickCentralLogoLanguageLink(LanguageData.Language language)
        {
            return clickProjectLinkByXPath(language);
        }

    }
}

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

using Resources = SeleniumDemo.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage
{
    public class HomePage : WikiPage
    {
        public IWebElement getCentralLogoLanguageLink(LanguageData.Language language)
        {
            return getElementAtXPath(LanguageData.getLanguageXPath(language));
        }

        public IWebElement getCentralLogoElement()
        {
            return getElementAtXPath(Resources.HomeXPathCentralLogoTitle);
        }


    }
}

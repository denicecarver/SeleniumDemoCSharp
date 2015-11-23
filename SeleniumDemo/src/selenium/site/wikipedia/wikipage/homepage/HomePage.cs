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

using Resources = SeleniumDemo.Properties.Resources;

using selenium.site.wikipedia.wikipage;

namespace com.selenium.wikitest.wikipage.homepage
{
    public class HomePage : WikiPage
    {

        public enum Language
        {
            English,
            Spanish,
            Japanese,
            Russian,
            French,
            German,
            Italian,
            Chinese,
            Polish,
            Portuguese
        }

        private String getExpectedLanguage(String expectedLanguage)
        {
            //return HomePageText.getString(expectedLanguage);
            return null;
        }

        public void openPage()
        {
            base.openPage(/*WikiPageText.getString("AnyPage.WikiHomeURL")*/"https://www.wikipedia.org/");
        }

        public bool isLanguageFound(Language val)
        {
            String xPathToLanguageLink = null;
            String nativeLanguageName = null;
            switch (val)
            {
                case Language.English:
                    xPathToLanguageLink = Resources.HomeXPathEnglish;
                    nativeLanguageName = Resources.HomeLanguageEnglish; 
                    break;
                case Language.Chinese:
                    xPathToLanguageLink = Resources.HomeXPathChinese;
                    nativeLanguageName = Resources.HomeLanguageChinese;
                    break;
                case Language.French:
                    xPathToLanguageLink = Resources.HomeXPathFrench;
                    nativeLanguageName = Resources.HomeLanguageFrench;
                    break;
                case Language.German:
                    xPathToLanguageLink = Resources.HomeXPathGerman;
                    nativeLanguageName = Resources.HomeLanguageGerman;
                    break;
                case Language.Italian:
                    xPathToLanguageLink = Resources.HomeXPathItalian;
                    nativeLanguageName = Resources.HomeLanguageItalian;
                    break;
                case Language.Japanese:
                    xPathToLanguageLink = Resources.HomeXPathJapanese;
                    nativeLanguageName = Resources.HomeLanguageJapanese;
                    break;
                case Language.Polish:
                    xPathToLanguageLink = Resources.HomeXPathPolish;
                    nativeLanguageName = Resources.HomeLanguagePolish;
                    break;
                case Language.Portuguese:
                    xPathToLanguageLink = Resources.HomeXPathPortuguese;
                    nativeLanguageName = Resources.HomeLanguagePortuguese;
                    break;
                case Language.Russian:
                    xPathToLanguageLink = Resources.HomeXPathRussian;
                    nativeLanguageName = Resources.HomeLanguageRussian;
                    break;
                case Language.Spanish:
                    xPathToLanguageLink = Resources.HomeXPathSpanish;
                    nativeLanguageName = Resources.HomeLanguageSpanish;
                    break;
                    
            }
            bool found = false;
            if (xPathToLanguageLink != null)
            {
                found = getDisplayedLanguage(xPathToLanguageLink).StartsWith(nativeLanguageName);
            }
            return found;
        }

        public string goToProjectLink(Language language)
        {
            return clickProjectLink(language.ToString());
        }

        public String goToListLinkByXPath(String xPath)
        {
            return clickProjectLinkByXPath(xPath);

        }

        public String goToListLinkByLinkName(String linkName)
        {
            return clickProjectLink(linkName);
        }

        public String getJapanesePageTitle()
        {
            IWebElement we = waitForElement(By.LinkText(/*HomePageText.getString("HomePage.LanguageJapaneseText")*/""));
            return we.Text;
        }

    }
}

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
            base.openPage(/*WikiPageText.getString("AnyPage.WikiHomeURL")*/"");
        }

        public bool isLanguageFound(Language val)
        {
            //return getDisplayedLanguage(HomePageText.getString("HomePage.LanguageXPath" + val.toString())).contains(getExpectedLanguage("HomePage.Language" + val.toString() + "Text"));
            return false;
        }

        public String goToProjectLink(String keyName)
        {
            //return clickProjectLink(HomePageText.getString(keyName));
            return null;
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

using System;
using System.Collections.Generic;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiPage
    {
        protected IWebDriver webDriver = new FirefoxDriver();

        protected String getDisplayedLanguage(String actualLanguage)
        {
            return getTextAtXPath(actualLanguage);
        }

        public IWebDriver getDriver()
        {
            return webDriver;
        }

        public void openPage(String url)
        {
            try
            {
                webDriver.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
        }

        public void openHomePage()
        {
            //openPage(WikiPageText.getString("AnyPage.WikiHomeURL"));
        }

        public String getTextAtXPath(String xpathToElement)
        {
            return waitForElement(By.XPath(xpathToElement)).Text;
        }

        public String getTextAtTitle(String titleOfElement)
        {
            return waitForElement(By.Name(titleOfElement)).Text;
        }

        private String getNthStringAtClassname(String className, int indexToElement)
        {
            //String returnString = "";
            //List<WebElement> classesIn = findElementsByClassName("searchresults");
            //WebElement element = classesIn.get(indexToElement);
            //if (element != null)
            //{
            //    returnString = element.getText();
            //}
            //return returnString;
            return null;
        }

        public String getSearchResultDetails()
        {
            return getNthStringAtClassname("searchresult", 0);
        }

        public String searchForRedirect(String redirectString)
        {

            searchFor(redirectString);
            webDriver.FindElement(By.LinkText(redirectString)).Click();
            return webDriver.Title;
        }

        protected String clickProjectLink(String linkName)
        {
            (webDriver.FindElement(By.PartialLinkText(linkName))).Click();
            return webDriver.Title;
        }

        public String clickProjectLinkByXPath(String xPath)
        {
            (webDriver.FindElement(By.XPath(xPath))).Click();
            return webDriver.Title;
        }

        public String clickProjectLinkByID(String id)
        {
            (webDriver.FindElement(By.Id(id))).Click();
            return webDriver.Title;
        }

        protected String getTooltipByLink(String link)
        {

            return webDriver.FindElement(By.PartialLinkText(link)).GetAttribute("title");

        }

        protected String getTooltipByID(String id)
        {
            return webDriver.FindElement(By.Id(id)).GetAttribute("title");
        }

        protected String getTooltipByXPath(String xPath)
        {
            return webDriver.FindElement(By.Id(xPath)).GetAttribute("title");
        }

        protected String getTooltipByCSS(String css)
        {
            return (webDriver.FindElement(By.CssSelector(css))).GetAttribute("title");
        }

        protected IReadOnlyList<IWebElement> findElementsByClassName(String elementClassName)
        {
            return webDriver.FindElements(By.ClassName(elementClassName));
        }

        protected IWebElement waitForElement(By by)
        {
            //int tenthSecond;
            //int sleepTime = 100;
            //for (tenthSecond = 1; tenthSecond <= 20/*200*/; tenthSecond++)
            //{
            //try
            //{
            return webDriver.FindElement(by);
            //}
            //catch (NoSuchElementException e)
            //{
            //    // swallow - expect to not find within wait period
            //    Debug.WriteLine("Tenth seconds waited:  " + tenthSecond);
            //}
            //try
            //{
            //    Thread.sleep(sleepTime);
            //}
            //catch (InterruptedException ei)
            //{
            //    Debug.WriteLine(ei.getMessage());
            //    Debug.WriteLine(ei.getStackTrace());
            //}
            //}
            //Debug.WriteLine("Failed at Tenth Second: " + tenthSecond);
            //throw new NoSuchElementException("Looking for element by: " + by.ToString());
        }

        public String searchFor(By elementHandle, String searchString)
        {
            // Enter expected text in search text box
            //waitForElement(By.id(WikiPageText.getString("AnyPage.SearchID"))).sendKeys(searchString);

            //// search is dependent on starting page
            //waitForElement(elementHandle).click();

            //return webDriver.getTitle();
            return null;
        }

        public String searchFor(String searchString)
        {
            //return searchFor(By.name(WikiPageText.getString("AnyPage.GoSearchName")),
            //        searchString);
            return null;
        }

        public void closeAnyBeggarOverlay()
        {

            //IWebElement beggarCloseButton = null;
            //try
            //{
            //    beggarCloseButton = webDriver.FindElement(By.XPath("//*[@id=\"B14_120719_5C_tp_ct-close\"]"));
            //}
            //catch (NoSuchElementException ex)
            //{
            //    // Swallow exception because this is the common, expected outcome
            //}

            //// If there is an overlay close button, click it
            //if (beggarCloseButton != null && beggarCloseButton.Displayed)
            //{
            //    beggarCloseButton.Click();
            //}
        }

        public void getUniqueScreenshot(String filenameNoExtension)
        {
            //getScreenshot(filenameNoExtension + CommonMethods.getUniqueStringFromCurrentMilliseconds());
        }

        public void getScreenshot(String filenameNoExtension)
        {
            //WebDriver augmentedDriver = new Augmenter().augment(webDriver);
            //File screenshot = ((TakesScreenshot)augmentedDriver).
            //        getScreenshotAs(OutputType.FILE);
            //try
            //{
            //    Debug.WriteLine(WikiPageText.getString("AnyPage.ErrorImagePath") + filenameNoExtension + ".png");
            //    FileUtils.copyFile(screenshot, new File(WikiPageText.getString("AnyPage.ErrorImagePath") + filenameNoExtension + ".png"));
            //}
            //catch (IOException e)
            //{
            //    Debug.WriteLine(e.StackTrace);
            //}
        }

        //public String getPageTitle()
        //{
        //    return webDriver.Title;
        //}

        public void closeBrowser()
        {
            webDriver.Quit();
        }

    }
}

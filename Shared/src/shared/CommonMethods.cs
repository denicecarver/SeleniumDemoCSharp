
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;

namespace shared
{
    public static class CommonMethods {

        public static IWebDriver webDriver = new FirefoxDriver();

        #region Error Handling
        public static string FormatAssertMessage(string expectedResult, string actualResult)
        {
            return "\n\tExpected Value: " + expectedResult +
                    "\n\tActual Value:  " + actualResult;
        }

        public static string FormatAssertMessage(string expectedResult, string actualResult, string id) {
            return "\n\tExpected Value: " + expectedResult +
                    "\n\tActual Value:  " + actualResult +
                    "\n\tID of dataItem:  " + id;
        }

        public static string GetUniqueStringFromCurrentMilliseconds()
        {
            string tmp = System.DateTime.Now.ToUniversalTime().ToString();
            return System.DateTime.Now.ToUniversalTime().ToString();//"yyyyMMddHHmmss"
            //Calendar cal = Calendar.getInstance(TimeZone.getTimeZone("UTC"));
            //return Long.toString(cal.getTimeInMillis());
        }

        public static void LoadLanguageLinkData(ReadOnlyCollection<IWebElement> weListPrimary)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=C:\\Users\\Don\\Music\\Documents\\SeleniumProjects\\SeleniumDemoCSharp\\SeleniumDemoTests\\src\\selenium\\site\\wikipedia\\wikidata\\wikidata.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    Debug.WriteLine(sh.ExecuteScalar("select Title from ResultLanguageLinks;"));

                    conn.Close();
                }
            }
            Debug.WriteLine("============================================");
            foreach (IWebElement we in weListPrimary)
            {
                Debug.WriteLine("id=" + we.GetAttribute("id"));
                Debug.WriteLine("class=" + we.GetAttribute("class"));
                Debug.WriteLine("lang=" + we.GetAttribute("lang"));
                Debug.WriteLine("dir=" + we.GetAttribute("dir"));
                Debug.WriteLine("title=" + we.GetAttribute("title"));
                Debug.WriteLine("href=" + we.GetAttribute("href"));
                Debug.WriteLine("data-convert-hans=" + we.GetAttribute("data-convert-hans"));
                Debug.WriteLine("Text=" + we.Text);
                Debug.WriteLine("============================================");
            }
        }

        public static void GetUniqueScreenshot(string filenameNoExtension)
        {
            //getScreenshot(filenameNoExtension + CommonMethods.getUniqueStringFromCurrentMilliseconds());
        }

        public static void GetScreenshot(string filenameNoExtension)
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
        #endregion

    }
}
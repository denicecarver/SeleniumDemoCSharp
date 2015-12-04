namespace shared
{
    public class CommonMethods {

        #region Error Handling
        public static string formatAssertMessage(string expectedResult, string actualResult)
        {
            return "\n\tExpected Value: " + expectedResult +
                    "\n\tActual Value:  " + actualResult;
        }

        public static string formatAssertMessage(string expectedResult, string actualResult, string id) {
            return "\n\tExpected Value: " + expectedResult +
                    "\n\tActual Value:  " + actualResult +
                    "\n\tID of dataItem:  " + id;
        }

        public static string getUniqueStringFromCurrentMilliseconds()
        {
            string tmp = System.DateTime.Now.ToUniversalTime().ToString();
            return System.DateTime.Now.ToUniversalTime().ToString();//"yyyyMMddHHmmss"
            //Calendar cal = Calendar.getInstance(TimeZone.getTimeZone("UTC"));
            //return Long.toString(cal.getTimeInMillis());
        }

        public void getUniqueScreenshot(string filenameNoExtension)
        {
            //getScreenshot(filenameNoExtension + CommonMethods.getUniqueStringFromCurrentMilliseconds());
        }

        public void getScreenshot(string filenameNoExtension)
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
using Language = selenium.site.wikipedia.languages.LanguageData.Language;
using TestResources = SeleniumDemoTests.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage.Tests
{
    public static class HomePageTestData
    {
        public static string GetLanguageHomepageUrl(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return TestResources.HomeURLEnglish;
                case Language.Chinese:
                    return TestResources.HomeURLChinese;
                case Language.French:
                    return TestResources.HomeURLFrench;
                case Language.German:
                    return TestResources.HomeURLGerman;
                case Language.Italian:
                    return TestResources.HomeURLItalian;
                case Language.Japanese:
                    return TestResources.HomeURLJapanese;
                case Language.Polish:
                    return TestResources.HomeURLPolish;
                case Language.Portuguese:
                    return TestResources.HomeURLPortuguese;
                case Language.Russian:
                    return TestResources.HomeURLRussian;
                case Language.Spanish:
                    return TestResources.HomeURLSpanish;
            }

            return null;
        }

        public static string GetNativeLanguageName(Language language)
        {

            switch (language)
            {
                case Language.English:
                    return TestResources.HomeLanguageEnglish;
                case Language.Chinese:
                    return TestResources.HomeLanguageChinese;
                case Language.French:
                    return TestResources.HomeLanguageFrench;
                case Language.German:
                    return TestResources.HomeLanguageGerman;
                case Language.Italian:
                    return TestResources.HomeLanguageItalian;
                case Language.Japanese:
                    return TestResources.HomeLanguageJapanese;
                case Language.Polish:
                    return TestResources.HomeLanguagePolish;
                case Language.Portuguese:
                    return TestResources.HomeLanguagePortuguese;
                case Language.Russian:
                    return TestResources.HomeLanguageRussian;
                case Language.Spanish:
                    return TestResources.HomeLanguageSpanish;
            }

            return null;
        }
    }
}

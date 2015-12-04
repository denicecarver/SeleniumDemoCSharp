using Language = selenium.site.wikipedia.languages.LanguageData.Language;
using TestResources = SeleniumDemoTests.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage.Tests
{
    public static class HomePageTestData
    {
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

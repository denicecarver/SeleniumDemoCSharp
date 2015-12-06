using Language = selenium.site.wikipedia.languages.LanguageData.Language;
using Resources = SeleniumDemo.Properties.Resources;

namespace com.selenium.wikitest.wikipage.homepage
{
    public static class HomePageData
    {

        public static string GetXPathToLanguageLink(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return Resources.HomeXPathCentralLogoEnglish;
                case Language.Chinese:
                    return Resources.HomeXPathCentralLogoChinese;
                case Language.French:
                    return Resources.HomeXPathCentralLogoFrench;
                case Language.German:
                    return Resources.HomeXPathCentralLogoGerman;
                case Language.Italian:
                    return Resources.HomeXPathCentralLogoItalian;
                case Language.Japanese:
                    return Resources.HomeXPathCentralLogoJapanese;
                case Language.Polish:
                    return Resources.HomeXPathCentralLogoPolish;
                case Language.Portuguese:
                    return Resources.HomeXPathCentralLogoPortuguese;
                case Language.Russian:
                    return Resources.HomeXPathCentralLogoRussian;
                case Language.Spanish:
                    return Resources.HomeXPathCentralLogoSpanish;
            }

            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Resources = SeleniumDemo.Properties.Resources;

namespace selenium.site.wikipedia.languages
{
    public static class LanguageData
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

        public static String getLanguageXPath(Language language)
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

        public static String getLanguageHomepageUrl(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return Resources.HomeURLEnglish;
                case Language.Chinese:
                    return Resources.HomeURLChinese;
                case Language.French:
                    return Resources.HomeURLFrench;
                case Language.German:
                    return Resources.HomeURLGerman;
                case Language.Italian:
                    return Resources.HomeURLItalian;
                case Language.Japanese:
                    return Resources.HomeURLJapanese;
                case Language.Polish:
                    return Resources.HomeURLPolish;
                case Language.Portuguese:
                    return Resources.HomeURLPortuguese;
                case Language.Russian:
                    return Resources.HomeURLRussian;
                case Language.Spanish:
                    return Resources.HomeURLSpanish;
            }

            return null;
        }

        public static String getNativeLanguageName(Language language)
        {

            switch (language)
            {
                case Language.English:
                    return Resources.HomeLanguageEnglish;
                case Language.Chinese:
                    return Resources.HomeLanguageChinese;
                case Language.French:
                    return Resources.HomeLanguageFrench;
                case Language.German:
                    return Resources.HomeLanguageGerman;
                case Language.Italian:
                    return Resources.HomeLanguageItalian;
                case Language.Japanese:
                    return Resources.HomeLanguageJapanese;
                case Language.Polish:
                    return Resources.HomeLanguagePolish;
                case Language.Portuguese:
                    return Resources.HomeLanguagePortuguese;
                case Language.Russian:
                    return Resources.HomeLanguageRussian;
                case Language.Spanish:
                    return Resources.HomeLanguageSpanish;
            }

            return null;
        }

    }
}

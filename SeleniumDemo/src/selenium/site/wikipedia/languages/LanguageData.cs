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
                    return Resources.HomeXPathEnglish;
                case Language.Chinese:
                    return Resources.HomeXPathChinese;
                case Language.French:
                    return Resources.HomeXPathFrench;
                case Language.German:
                    return Resources.HomeXPathGerman;
                case Language.Italian:
                    return Resources.HomeXPathItalian;
                case Language.Japanese:
                    return Resources.HomeXPathJapanese;
                case Language.Polish:
                    return Resources.HomeXPathPolish;
                case Language.Portuguese:
                    return Resources.HomeXPathPortuguese;
                case Language.Russian:
                    return Resources.HomeXPathRussian;
                case Language.Spanish:
                    return Resources.HomeXPathSpanish;
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

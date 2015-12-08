using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;

using Resources = SeleniumDemo.Properties.Resources;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiChildPage
    {
        /// <summary>
        /// Classes that inherit this class will belong to a WikiLoadPage
        /// </summary>
        //TODO: Figure out how to require subclasses only exist within a WikiLoadPage
        protected WikiLoadPage wikiPage = null;

        public WikiChildPage(WikiLoadPage wikiPage)
        {
            this.wikiPage = wikiPage;
        }
    }
}

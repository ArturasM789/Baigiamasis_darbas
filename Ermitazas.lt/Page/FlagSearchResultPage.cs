using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class FlagSearchResultPage : BasePage
    {
        public FlagSearchResultPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement searchResult => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full > div > div.grid.grid-cols-2.md\\:grid-cols-3.xl\\:grid-cols-4 > div > div.relative > a > div > span > img"));
        public void ClickSearchedItem()
        {
            searchResult.Click();
        }
    }
}

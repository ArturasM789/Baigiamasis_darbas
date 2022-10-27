
using NUnit.Framework;
using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class ErmitazasPage : BasePage
    {
        public ErmitazasPage(IWebDriver chromeDriver) : base(chromeDriver) { }

        private string pageAddress => "https://www.ermitazas.lt/";
        private IWebElement shopsButton => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > header > div.relative.hidden.md\\:block > div:nth-child(1) > div > div > div.mt-6.flex.flex-grow.flex-col.items-center.gap-8.overflow-hidden.md\\:mt-0.md\\:flex-row.md\\:gap-6.md\\:pl-10 > div > div > a > span"));
        private IWebElement searchTab => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > header > div.relative.hidden.md\\:block > div:nth-child(3) > div:nth-child(1) > div > div.flex.flex-grow.justify-between.gap-4 > div.h-\\[40px\\].max-w-\\[780px\\].flex-grow > div > div > div > input"));
        private IWebElement sodoPrekes => Driver.FindElement(By.CssSelector("#homepage-category-nav > nav > ul > li:nth-child(8) > div > span"));
        private IWebElement zemesTrasosSeklos => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > a:nth-child(2) > div.relative.my-2.flex.items-center.justify-center.pt-\\[68\\.7\\%\\].md\\:mt-4.md\\:mb-1\\.5 > span > img"));
        private IWebElement skalda => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.hidden.lg\\:block.w-80 > ul > li:nth-child(4) > a"));
        private IWebElement filterSkalda => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > div:nth-child(1) > div > div:nth-child(1) > div > div > div > div.mx-4.flex.w-full.items-center.overflow-hidden.whitespace-nowrap.rounded-sm.font-bold.placeholder-transparent.focus\\:outline-none > span"));
        private IWebElement naujausiosPrekes => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > div:nth-child(1) > div > div:nth-child(1) > div > div > ul > li:nth-child(2)"));
        private IWebElement filter => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > div:nth-child(1) > div > div:nth-child(1) > div > div > div"));

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void ClickShopsButton()
        {
            shopsButton.Click();
        }
        public void InputToSearchBar(string itemToSearch)
        {
            searchTab.SendKeys(itemToSearch + Keys.Enter);
        }
        public void ClickSodoPrekes()
        {
            sodoPrekes.Click();
        }
        public void ClickZemesTrasosSeklos()
        {
            zemesTrasosSeklos.Click();
        }
        public void ClickSkalda()
        {
            skalda.Click();
        }
        public void ClickFilterSkalda()
        {
            filterSkalda.Click();
        }
        public void ClickNaujausiosPrekes()
        {
            naujausiosPrekes.Click();
        }
        public void AssertSuriuosiuotaPagalNaujausias()
        {
            Assert.IsTrue(filter.Text.Contains("Naujausios prekės"));
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class ErmitazasShopsPage : BasePage
    {
        public ErmitazasShopsPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private string shopAddress => "Ozo g. 25";
        private IWebElement cityButton => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.items-start.lg\\:flex > div.flex-grow.lg\\:ml-12 > div > div.relative > div > div.mx-4.flex.w-full.items-center.overflow-hidden.whitespace-nowrap.rounded-sm.font-bold.placeholder-transparent.focus\\:outline-none"));
        private IWebElement vilniusSelection => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.items-start.lg\\:flex > div.flex-grow.lg\\:ml-12 > div > div.relative > ul > li:nth-child(8)"));
        private IWebElement addressTab => Driver.FindElement(By.CssSelector("#department-card-500 > div > p"));
        public void ClickCityButton()
        {
            cityButton.Click();
        }
        public void SelectVilnius()
        {
            vilniusSelection.Click();
        }
        public void ConfirmAddress()
        {
            Assert.IsTrue(addressTab.Text.Contains(shopAddress));
        }
    }
}

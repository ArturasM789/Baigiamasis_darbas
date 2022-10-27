using NUnit.Framework;
using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class FlagPage : BasePage
    {

        public FlagPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement priceTag => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div:nth-child(1) > div.mt-4.lg\\:mt-7 > div > div.lg\\:ml-\\[27px\\].lg\\:inline-block.lg\\:w-\\[calc\\(50\\%-27px\\)\\] > div.mt-2.flex.flex-col.items-start.justify-between.gap-4.sm\\:flex-row.sm\\:items-center > div.inline-flex.items-end.gap-6 > div > div > div > div > span.font-bold.Price_price-base__awdnK.Price_price-normal__LDPQk"));
        public void AssertPrice()
        {
            Assert.IsTrue(priceTag.Text.Contains("25,99"));
        }
    }
}

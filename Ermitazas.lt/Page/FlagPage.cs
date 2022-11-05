using NUnit.Framework;
using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class FlagPage : BasePage
    {

        public FlagPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement priceTag => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/main/div[1]/div[2]/div/div[2]/div[1]/div[1]/div/div/div/div/span[1]"));
        public void AssertPrice()
        {
            Assert.IsTrue(priceTag.Text.Contains("25,99"));
        }
    }
}

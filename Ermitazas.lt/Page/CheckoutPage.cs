using NUnit.Framework;
using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private static IWebElement checkoutPriceTab => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/main/div[1]/div/div[2]/div[1]/div[3]/span[2]"));
        public void AssertThePrice()
        {
            Assert.IsTrue(checkoutPriceTab.Text.Contains("50,44"));
        }
    }
}



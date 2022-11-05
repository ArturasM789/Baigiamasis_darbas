using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class WeAreHiringPage : BasePage
    {
        public WeAreHiringPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement darboPasiulymai => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/main/div/div/div[2]/div[2]/div/h4[2]/a"));
        public void ClickJobOffers()
        {
            darboPasiulymai.Click();
        }
    }
}

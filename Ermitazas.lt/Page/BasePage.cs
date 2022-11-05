using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;
        public BasePage(IWebDriver chromeDriver)
        {
            Driver = chromeDriver;
        }

    }
}

using NUnit.Framework;
using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class CVBankasErmitazasJobOffersPage : BasePage
    {
        public CVBankasErmitazasJobOffersPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement expectedSalaryOfSalesManager => Driver.FindElement(By.XPath("//*[@id=\"js_id_id_ad_list\"]/article[3]/a/div/div[2]/span/span/span/span[1]/span[1]"));
        string expectedSalary = "1610";

        public void AssertExpectedSalary()
        {
            Assert.IsTrue(expectedSalaryOfSalesManager.Text.Contains(expectedSalary));
        }
    }
}

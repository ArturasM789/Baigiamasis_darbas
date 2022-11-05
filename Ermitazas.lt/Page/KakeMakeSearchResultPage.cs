using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class KakeMakeSearchResultPage : BasePage
    {
        public KakeMakeSearchResultPage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement searchResult => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/main/div/div[2]/div[2]/div/div[2]/div/div[1]/a/div/span/img"));
        public void ClickSearchResult()
        {
            searchResult.Click();
        }
    }
}

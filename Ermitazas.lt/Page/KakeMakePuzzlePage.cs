using OpenQA.Selenium;

namespace Ermitazas.lt.Page
{
    public class KakeMakePuzzlePage : BasePage
    {

        public KakeMakePuzzlePage(IWebDriver chromeDriver) : base(chromeDriver) { }
        private IWebElement addToQuantity => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/main/div[1]/div[2]/div/div[2]/div[2]/div/div[2]/div/div/div/button[2]"));
        private IWebElement addToBasket => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/main/div[1]/div[2]/div/div[2]/div[3]/div/button"));
        private IWebElement basketCheckout => Driver.FindElement(By.XPath("//*[@id=\"overlay-root\"]/div/div/div[2]/div/div[2]/div/div[2]/div[2]/button"));
        int quantity = 5;
        public void AddToQuantityOfItems()

        {
            for (int i = 1; i < quantity; i++)
            {
                addToQuantity.Click();
            }
        }
        public void AddToBasket()
        {
            addToBasket.Click();
        }
        public void GoToBasketCheckout()
        {
            basketCheckout.Click();
        }
    }
}

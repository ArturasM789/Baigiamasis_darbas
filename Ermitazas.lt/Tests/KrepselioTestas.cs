using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    public class KrepselioTestas : BaseTest
    {
        [Test]
        public static void KrepselioKainosPatikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            KakeMakeSearchResultPage kakeMakeSearchResultPage = new KakeMakeSearchResultPage(chromeDriver);
            KakeMakePuzzlePage kakeMakePuzzlePage = new KakeMakePuzzlePage(chromeDriver);
            CheckoutPage checkoutPage = new CheckoutPage(chromeDriver);
            page.NavigateToPage();
            page.CloseAdd();
            page.AcceptCookies();
            page.InputToSearchBar("Dėlionė KAKĖ MAKĖ IR DRAUGAI");
            kakeMakeSearchResultPage.ClickSearchResult();
            kakeMakePuzzlePage.AddToQuantityOfItems();
            kakeMakePuzzlePage.AddToBasket();
            kakeMakePuzzlePage.GoToBasketCheckout();
            checkoutPage.AssertThePrice();
        }
    }
}

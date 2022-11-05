using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    public class VeliavosKainosPatikrinimoTestas : BaseTest
    {
        [Test]

        public static void VeliavosKainosPatikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            FlagSearchResultPage flagSearchResultPage = new FlagSearchResultPage(chromeDriver);
            FlagPage flagPage = new FlagPage(chromeDriver);

            page.NavigateToPage();
            page.CloseAdd();
            page.AcceptCookies();
            page.InputToSearchBar("Stiebinė Lietuvos valstybės istorinė vėliava, 100 x 170 cm");
            flagSearchResultPage.ClickSearchedItem();
            flagPage.AssertPrice();
        }
    }
}

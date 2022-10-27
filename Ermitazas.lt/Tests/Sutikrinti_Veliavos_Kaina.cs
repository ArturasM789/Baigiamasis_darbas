using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    public class Sutikrinti_Veliavos_Kaina : BaseTest
    {
        [Test]

        public static void VeliavosKainosPatikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            FlagSearchResultPage flagSearchResultPage = new FlagSearchResultPage(chromeDriver);
            FlagPage flagPage = new FlagPage(chromeDriver);

            page.NavigateToPage();
            page.InputToSearchBar("Stiebinė Lietuvos valstybės istorinė vėliava, 100 x 170 cm");
            flagSearchResultPage.ClickSearchedItem();
            flagPage.AssertPrice();
        }
    }



}

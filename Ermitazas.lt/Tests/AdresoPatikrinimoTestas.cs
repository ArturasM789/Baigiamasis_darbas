using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    public class AdresoSutikrinimas : BaseTest
    {

        [Test]

        public static void AdresoPatikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            ErmitazasShopsPage shopsPage = new ErmitazasShopsPage(chromeDriver);
            page.NavigateToPage();
            page.CloseAdd();
            page.AcceptCookies();
            page.ClickShopsButton();
            shopsPage.ClickCityButton();
            shopsPage.SelectVilnius();
            shopsPage.ConfirmAddress();
        }




    }
}

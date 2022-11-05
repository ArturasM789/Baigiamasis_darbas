using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    public class VadybininkoAlgosPatikrinimoTestas : BaseTest
    {
        [Test]
        public static void DidmeninesPrekybosVadybininkoAlgosPatikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            WeAreHiringPage weAreHiringPage = new WeAreHiringPage(chromeDriver);
            CVBankasErmitazasJobOffersPage cVBankasErmitazasJobOffersPage = new CVBankasErmitazasJobOffersPage(chromeDriver);
            page.NavigateToPage();
            page.CloseAdd();
            page.AcceptCookies();
            page.ClickMesSiulomeDarba();
            weAreHiringPage.ClickJobOffers();
            cVBankasErmitazasJobOffersPage.AssertExpectedSalary();
        }
    }
}

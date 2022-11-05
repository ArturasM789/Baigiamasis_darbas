using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    public class SkaldosKainosSutikrinimoTestas : BaseTest
    {
        [Test]
        public static void SkaldosKainosSutikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            page.NavigateToPage();
            page.CloseAdd();
            page.AcceptCookies();
            page.ClickSodoPrekes();
            page.ClickZemesTrasosSeklos();
            page.ClickSkalda();
            page.ClickFilterSkalda();
            page.ClickNaujausiosPrekes();
            page.AssertSuriuosiuotaPagalNaujausias();
        }
    }
}

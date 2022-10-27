using Ermitazas.lt.Page;
using NUnit.Framework;

namespace Ermitazas.lt.Tests
{
    internal class SkaldosNaujausiosPrekesKaina : BaseTest
    {
        [Test]
        public static void SkaldosKainosSutikrinimas()
        {
            ErmitazasPage page = new ErmitazasPage(chromeDriver);
            page.NavigateToPage();
            page.ClickSodoPrekes();
            page.ClickZemesTrasosSeklos();
            page.ClickSkalda();
            page.ClickFilterSkalda();
            page.ClickNaujausiosPrekes();
            page.AssertSuriuosiuotaPagalNaujausias();
        }
    }
}

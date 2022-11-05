using Ermitazas.Drivers;
using Ermitazas.lt.Page;
using Ermitazas.lt.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Ermitazas.lt.Tests
{
    public class BaseTest
    {
        protected static IWebDriver chromeDriver;
        protected static CheckoutPage checkoutPage;
        protected static CVBankasErmitazasJobOffersPage cVBankasErmitazasJobOffersPage;
        protected static ErmitazasPage ermitazasPage;
        protected static ErmitazasShopsPage ermitazasShopsPage;
        protected static FlagPage flagPage;
        protected static FlagSearchResultPage flagSearchResultPage;
        protected static KakeMakePuzzlePage kakeMakePuzzlePage;
        protected static KakeMakeSearchResultPage kakeMakeSearchResultPage;
        protected static WeAreHiringPage weAreHiringPage;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = CustomDriver.GetChromeIncognitoDriver();
            checkoutPage = new CheckoutPage(chromeDriver);
            cVBankasErmitazasJobOffersPage = new CVBankasErmitazasJobOffersPage(chromeDriver);
            ermitazasPage = new ErmitazasPage(chromeDriver);
            ermitazasShopsPage = new ErmitazasShopsPage(chromeDriver);
            flagPage = new FlagPage(chromeDriver);
            flagSearchResultPage = new FlagSearchResultPage(chromeDriver);
            weAreHiringPage = new WeAreHiringPage(chromeDriver);
            kakeMakePuzzlePage = new KakeMakePuzzlePage(chromeDriver);
            kakeMakeSearchResultPage = new KakeMakeSearchResultPage(chromeDriver);
        }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(chromeDriver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

    }
}

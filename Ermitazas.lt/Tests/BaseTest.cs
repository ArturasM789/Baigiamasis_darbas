using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Ermitazas.lt.Tests
{
    public class BaseTest
    {
        protected static IWebDriver chromeDriver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

    }
}

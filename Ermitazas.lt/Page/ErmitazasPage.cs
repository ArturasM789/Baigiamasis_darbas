
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Ermitazas.lt.Page
{
    public class ErmitazasPage : BasePage
    {
        public ErmitazasPage(IWebDriver chromeDriver) : base(chromeDriver) { }

        private string pageAddress => "https://www.ermitazas.lt/";


        private IWebElement shopsButton => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > header > div.relative.hidden.md\\:block > div:nth-child(1) > div > div > div.mt-6.flex.flex-grow.flex-col.items-center.gap-8.overflow-hidden.md\\:mt-0.md\\:flex-row.md\\:gap-6.md\\:pl-10 > div > div > a > span"));
        private IWebElement searchTab => Driver.FindElement(By.Id("input-undefined"));
        private IWebElement sodoPrekes => Driver.FindElement(By.CssSelector("#homepage-category-nav > nav > ul > li:nth-child(8) > div > span"));
        private IWebElement zemesTrasosSeklos => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > a:nth-child(2) > div.relative.my-2.flex.items-center.justify-center.pt-\\[68\\.7\\%\\].md\\:mt-4.md\\:mb-1\\.5 > span > img"));
        private IWebElement skalda => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.hidden.lg\\:block.w-80 > ul > li:nth-child(4) > a"));
        private IWebElement filterSkalda => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > div:nth-child(1) > div > div:nth-child(1) > div > div"));
        private IWebElement naujausiosPrekes => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > div:nth-child(1) > div > div:nth-child(1) > div > ul > li:nth-child(2)"));
        private IWebElement filter => Driver.FindElement(By.CssSelector("#__next > div.mx-auto.grid.h-full.grid-cols-1.grid-rows-\\[auto_1fr_auto\\].transition-colors.duration-150 > main > div > div > div.flex.lg\\:gap-\\[54px\\] > div.w-full.max-w-\\[948px\\].lg\\:w-2\\/3.xl\\:w-3\\/4 > div.my-6 > div > div:nth-child(1) > div > div:nth-child(1) > div > div > div"));
        private IWebElement mesSiulomeDarba => Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/footer/div[1]/div/div/div/div[1]/div[2]/div[1]/div[2]/div/div/a"));
        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27jg7g8WHa7Z8a6MxEARrLfL5Ig5TEhGPvUmfFQiouzFKdP98oOfQX/g==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cver:1%2Cutc:1665163467486%2Cregion:%27lt%27}",
                "www.ermitazas.lt",
                "/",
                DateTime.Now.AddDays(2));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();

        }
        public void CloseAdd()
        {
            Driver.SwitchTo().Frame(Driver.FindElement(By.Id("mt-7fec06649a430162")));
            Driver.FindElement(By.CssSelector("body > div.modal.fade.in > div > div > a > svg > path")).Click();
            Driver.SwitchTo().DefaultContent();
        }
        public void ClickShopsButton()
        {
            shopsButton.Click();
        }
        public void InputToSearchBar(string itemToSearch)
        {
            searchTab.SendKeys(itemToSearch + Keys.Enter);
        }
        public void ClickSodoPrekes()
        {
            sodoPrekes.Click();
        }
        public void ClickZemesTrasosSeklos()
        {
            zemesTrasosSeklos.Click();
        }
        public void ClickSkalda()
        {
            skalda.Click();
        }
        public void ClickFilterSkalda()
        {
            filterSkalda.Click();
        }
        public void ClickNaujausiosPrekes()
        {
            naujausiosPrekes.Click();
        }
        public void AssertSuriuosiuotaPagalNaujausias()
        {
            Assert.IsTrue(filter.Text.Contains("Naujausios prekės"));
        }
        public void ClickMesSiulomeDarba()
        {
            mesSiulomeDarba.Click();
        }
    }
}

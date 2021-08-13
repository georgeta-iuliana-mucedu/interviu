
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Creeare_Cont
{
    [TestClass]
    public class Select
    {

        private IWebDriver driver;

        [TestInitialize]

        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://politrip.com/account/sign-up");
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void Multi_select()
        {


            driver.FindElement(By.CssSelector("#cookiescript_close")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#first-name")).SendKeys("Georgeta-Iuliana");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#last-name")).SendKeys("Mucedu");

            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#email")).SendKeys("georgetaiuliana99@yahoo.com");

            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("#sign-up-password-input")).SendKeys("Alabala12");
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("#sign-up-confirm-password-input")).SendKeys("Alabala12");
            driver.FindElement(By.CssSelector(".button-label")).Click();
            Thread.Sleep(1500);


        }



        [TestCleanup]

        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}

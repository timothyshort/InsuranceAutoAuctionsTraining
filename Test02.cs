using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * Test Project #2 - Using Selenium IDE
 * Record + Run the User Login form
 * Copy/Paste, RUN (FAIL), Add Thread.Sleep()
 */

namespace TestingProject01
{
    [TestFixture]
    public class Test02
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://sdettraining.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void SeleniumIDETest()
        {
            driver.Navigate().GoToUrl(baseURL + "/projects/");
            driver.FindElement(By.LinkText("Account Management System")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("MainContent_txtUserName")).Clear();
            driver.FindElement(By.Id("MainContent_txtUserName")).SendKeys("tim@testemail.com");
            driver.FindElement(By.Id("MainContent_txtPassword")).Clear();
            driver.FindElement(By.Id("MainContent_txtPassword")).SendKeys("password");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("MainContent_btnLogin")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}

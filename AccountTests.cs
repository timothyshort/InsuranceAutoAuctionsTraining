using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace TestingProject01
{

    public class AccountTests
    {
        public IWebDriver driver;
        string browser = "FF";
        string webUrl = "http://www.sdettraining.com/projects";

        [SetUp]
        public void Setup()
        {
            driver = Browser.NewBrowser(browser, webUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void NewUserSignUpTest()
        {
            driver.FindElement(By.LinkText("Account Management System")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("createaccount")).Click();
        }

        [Test]
        public void LoginTest()
        {
            driver.FindElement(By.LinkText("Account Management System")).Click();
            string username = "tim";
            string password = "pass";
            Thread.Sleep(3000);
            driver.FindElement(By.Id("MainContent_txtUserName")).SendKeys(username);
            driver.FindElement(By.Name("ctl00$MainContent$txtPassword")).SendKeys(password);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("MainContent_btnLogin")).Click();

        }
    }
}

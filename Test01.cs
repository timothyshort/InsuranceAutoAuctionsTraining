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
 * Test Project #1: User Login Form
 * Goal: set outline for test plan
 * Introduction to Selenium WebDriver
 * Prepare environment (Selenium, Firefox, NUnit)
 * Parameterize data with variables
 */

namespace TestingProject01
{
    class Test01
    {
        [Test]
        public void LogInTest()
        {
            // Step 7: Initialize properties
            IWebDriver driver;
            string webUrl;
            string email = "tim@testemail.com";
            string password;

            // Step 1: Open Browser
            driver = new FirefoxDriver();

            // Step 2: Navigate to Test Page
            driver.Navigate().GoToUrl("http://sdettraining.com/trguitransactions/Account.aspx");
            Thread.Sleep(1000);

            // Step 3: Enter username
            driver.FindElement(By.Id("MainContent_txtUserName")).SendKeys(email);

            // Step 4: Enter password
            driver.FindElement(By.Id("MainContent_txtPassword")).SendKeys("password");
            Thread.Sleep(2000);

            // Step 5: Click login
            driver.FindElement(By.Id("MainContent_btnLogin")).Click();

            // Step 6: Assert
            // Code comes later
        }
    }
}

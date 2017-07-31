using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Test Project #3 - NUnit Framework with Additional Web Elements
 * User Registration Form
 * SetUp & TearDown Attributes
 */

namespace TestingProject01
{
    class Test03
    {
        // 2. Class properties
        private IWebDriver driver;
        private string webUrl = "http://sdettraining.com/trguitransactions/Account.aspx";

        [SetUp]
        public void Setup()
        {
            // 9. Cross-Browser Testing
            string browserType = "Chrome";
            if (browserType.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browserType.Equals("Firefox"))
            {
                driver = new FirefoxDriver();

            }
            else if (browserType.Equals("IE"))
            {
                driver = new InternetExplorerDriver();
            }
            else
            {
                driver = new FirefoxDriver();
                browserType = "Firefox";
            }

            // 1. Setup method
            // driver = new FirefoxDriver();

            // 8. Manage WebDriver
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.Navigate().GoToUrl(webUrl);
            Console.WriteLine("Starting Test using " + browserType.ToUpper());
        }

        [TearDown]
        public void TearDown()
        {
            // 5. TearDown
            driver.Quit();
            Console.WriteLine("Ending Test");
        }

        [Test]
        public void NewAccountTest()
        {
            Console.WriteLine("Running New Account Test");

            // 4. Test Steps
            driver.FindElement(By.Id("createaccount")).Click();
            //Thread.Sleep(1000);
            driver.FindElement(By.Id("MainContent_txtFirstName")).SendKeys("Tim");
            driver.FindElement(By.Id("MainContent_txtLastName")).SendKeys("Short");

            // Radio button: Click
            driver.FindElement(By.Id("MainContent_Male")).Click();

            driver.FindElement(By.Id("MainContent_txtEmail")).SendKeys("tim2@testemail.com");
            driver.FindElement(By.Id("MainContent_txtPassword")).SendKeys("password");
            driver.FindElement(By.Id("MainContent_txtVerifyPassword")).SendKeys("password");
            driver.FindElement(By.Id("MainContent_txtHomePhone")).SendKeys("8887863033");
            driver.FindElement(By.Id("MainContent_txtCellPhone")).SendKeys("8887863033");

            // Drop-Down: new SelectElement from Selenium.Support
            new SelectElement(driver.FindElement(By.Id("MainContent_menuCountry"))).SelectByText("Italy");

            // Checkbox: Click
            driver.FindElement(By.Id("MainContent_checkWeeklyEmail")).Click();
            driver.FindElement(By.Id("MainContent_checkUpdates")).Click();

            // TextArea: SendKeys
            driver.FindElement(By.Id("MainContent_txtInstructions")).SendKeys("Signing up!");

            //Thread.Sleep(2000);
            driver.FindElement(By.Id("MainContent_btnSubmit")).Click();

            // 9. Assert
            Thread.Sleep(1000);
            string result = driver.FindElement(By.Id("MainContent_lblTransactionResult")).Text;
            string expected = "success";
            Console.WriteLine("Confirmation: " + result);
            // Assert.Equals(expected, result);
            StringAssert.Contains(expected, result);
        }
    }
}
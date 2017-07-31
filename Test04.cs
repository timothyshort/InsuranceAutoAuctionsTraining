using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Test Project #4 - Arrays
 * User Registration Form
 */

namespace TestingProject01
{
    class Test04
    {
        [Test]
        public void NewAccountTestArrays()
        {
            IWebDriver driver;
            string webUrl = "http://sdettraining.com/trguitransactions/Account.aspx";
            string[] Emails = { "iaa-1@trainingrite.com", "iaa-2@trainingrite.com", "iaa-3@trainingrite.com" };
            string[] LastNames = { "Smith", "Johnson", "Williams" };
            int length = Emails.Length;
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("TEST CASE: " + LastNames[i]);
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                driver.Navigate().GoToUrl(webUrl);
                string email = Emails[i];

                driver.FindElement(By.Id("createaccount")).Click();

                // Test Data
                driver.FindElement(By.Id("MainContent_txtFirstName")).SendKeys("Tim");
                driver.FindElement(By.Id("MainContent_txtLastName")).SendKeys(LastNames[i]); // real-time parameterization
                driver.FindElement(By.Id("MainContent_Male")).Click();
                driver.FindElement(By.Id("MainContent_txtEmail")).SendKeys(email);
                driver.FindElement(By.Id("MainContent_txtPassword")).SendKeys("password");
                driver.FindElement(By.Id("MainContent_txtVerifyPassword")).SendKeys("password");
                driver.FindElement(By.Id("MainContent_txtHomePhone")).SendKeys("8887863033");
                driver.FindElement(By.Id("MainContent_txtCellPhone")).SendKeys("8887863033");
                new SelectElement(driver.FindElement(By.Id("MainContent_menuCountry"))).SelectByText("Italy");
                driver.FindElement(By.Id("MainContent_checkWeeklyEmail")).Click();
                driver.FindElement(By.Id("MainContent_checkUpdates")).Click();
                driver.FindElement(By.Id("MainContent_txtInstructions")).SendKeys("Signing up!");

                // Take Screenshot
                Screenshot screenshot1 = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot1.SaveAsFile(@"C:\Users\owner\Documents\visual studio 2015\Projects\TestingProject01\TestingProject01\Output\Screenshot-" + email + "-BEFORE.jpg", ScreenshotImageFormat.Jpeg);

                Thread.Sleep(4000); // Add this to show the parameterized data
                driver.FindElement(By.Id("MainContent_btnSubmit")).Click();

                Screenshot screenshot2 = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot2.SaveAsFile(@"C:\Users\owner\Documents\visual studio 2015\Projects\TestingProject01\TestingProject01\Output\Screenshot-" + email + "-AFTER.jpg", ScreenshotImageFormat.Jpeg);

                // Assert
                string result = driver.FindElement(By.Id("MainContent_lblTransactionResult")).Text;
                string expected = "success";
                Console.WriteLine("Confirmation: " + result);
                // Assert.Equals(expected, result);
                StringAssert.Contains(expected, result);
                driver.Close();
            }
            
        }
    }
}

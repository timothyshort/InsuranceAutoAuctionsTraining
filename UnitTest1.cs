using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace TestingProject01
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            
        }

        [TestMethod]
        public void TestFile()
        {
            List<string> dataList = new List<string>();
            dataList.Add("2");
            dataList.Add("1");
            dataList.Add("5");
            DataReaders.File.WritetoTxt("test.txt", dataList);
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
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

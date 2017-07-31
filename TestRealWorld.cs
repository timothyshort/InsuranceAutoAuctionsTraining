using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01
{
    class TestRealWorld
    {
        private IWebDriver driver;

        [Test]
        public void IAATest()
        {
            driver = Browser.NewBrowser("FF", "http://www.iaai.com");
            SmokeTests.Tests.GetAllLinks(driver);
            // driver = Browser.NewBrowser("IE", "www.iaai.com");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("New test");
                driver.Navigate().GoToUrl("www.iaai.com");
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    // Action Class - hover
                    Actions action = new Actions(driver);
                    IWebElement vehicleHover = driver.FindElement(By.XPath("html/body/div[1]/div[2]/header/div/nav/ul/li[1]/a/i"));
                    action.MoveToElement(vehicleHover).Perform();

                    System.Threading.Thread.Sleep(2000);

                    IWebElement advancedSearchClick = driver.FindElement(By.XPath("html/body/div[1]/div[2]/header/div/nav/ul/li[1]/ul/li[1]/a"));
                    action.MoveToElement(advancedSearchClick).Click().Perform();



                    //driver.FindElement(By.Id("yui_3_10_0_1_1494863257143_218")).Click();
                    // ERROR: Caught exception [ERROR: Unsupported command [waitForPopUp |  | 30000]]
                    driver.FindElement(By.Id("navItem3")).Click();
                    driver.FindElement(By.LinkText("Advanced Search")).Click();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_rbFMCType")).Click();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_rbFAMType")).Click();
                    driver.FindElement(By.CssSelector("span.citybranchname")).Click();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cbATypeHighEnd")).Click();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cbMk1000012")).Click();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_cbMd1000877")).Click();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_startYearTxt")).Clear();
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_startYearTxt")).SendKeys("2010");
                    driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_FindVehicleBottom")).Click();
                }
                catch (NoSuchElementException e)
                {
                    Console.WriteLine("Could not find element");
                    Console.Write(e.Message);
                    // Assert.Fail();
                }
                catch (ElementNotVisibleException e)
                {
                    Console.WriteLine("Could not find element");
                    Console.Write(e.Message);
                    // Assert.Fail();
                }

            }
        }

        [Test]
        public void TrainingRiteTest()
        {
            IWebDriver driver = Browser.NewBrowser("FF", "http://www.trainingrite.com");
            SmokeTests.Tests.PageTitle(driver,"TrainingRite");
        }

        [Test]
        public void Priceline()
        {

        }

        [Test]

        public void AutoTrader()
        {

        }
    }
}

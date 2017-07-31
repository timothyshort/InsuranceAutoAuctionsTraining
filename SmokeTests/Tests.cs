using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01.SmokeTests
{
    class Tests
    {
        public static void PageTitle(IWebDriver driver, string ExpectedCritera)
        {
            string actual = driver.Title;
            StringAssert.Contains(ExpectedCritera, actual);
        }
        public static void ElementPresent(IWebDriver driver, string element)
        {
            // Code later
        }

        public static void GetAllLinks(IWebDriver driver)
        {
            Console.WriteLine("Fetching links");
            IList<IWebElement> Links = driver.FindElements(By.TagName("a"));
            foreach(IWebElement element in Links)
            {
                Console.WriteLine(element.ToString());
            }
        }

        public static void AllTests(IWebDriver driver)
        {
            /*
             * PageTitle(driver, "Selenium");
            ElementPresent(driver, "id('name')");
            ElementPresent(driver, "id('id')");
            */
        }

        public Tests(IWebDriver driver)
        {
            /*AllTests();
            this.driver = driver;
            */
        }
    }
}

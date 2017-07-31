using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01.Pages
{
    class HomePage
    {

        public static void SearchItem(IWebDriver driver, string itemSearch)
        {
            driver.FindElement(By.Name("txtSearch")).Clear();
            driver.FindElement(By.Name("txtSearch")).SendKeys(itemSearch);
        }

        public static void ClickSearch(IWebDriver driver)
        {
            driver.FindElement(By.Id("Go")).Click();
        }
        
        
    }
}

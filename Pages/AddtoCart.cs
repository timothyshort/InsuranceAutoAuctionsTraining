using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01.Pages
{
    class AddtoCart
    {
        public void Add(IWebDriver driver, string item)
        {
            driver.FindElement(By.Id(item)).Click();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01.Pages
{
    class ModifyCart
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "txtItemQty1")]
        private IWebElement TextQuantity { get; set;}

        [FindsBy(How = How.Id, Using ="Recalc")]
        private IWebElement RecalculateButtion { get; set;}

        [FindsBy(How = How.XPath,Using = "(//input[@name='cmdSubmit'])[3]")]
        private IWebElement SubmitButton { get; set; }

        public ModifyCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void UpdateCart(string Qty)
        {
            TextQuantity.SendKeys(Qty);
            RecalculateButtion.Click();
            SubmitButton.Click();
        }
        /*
        driver.FindElement(By.Name("txtItemQty1")).Clear();
        driver.FindElement(By.Name("txtItemQty1")).SendKeys("5");
        driver.FindElement(By.Id("Recalc")).Click();
        driver.FindElement(By.XPath("(//input[@name='cmdSubmit'])[3]")).Click();
        */
    }
}

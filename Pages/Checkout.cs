using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01.Pages
{
    class Checkout
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name,Using = "txtCustomerName")]
        private IWebElement TextName { get; set; }

        [FindsBy(How = How.Name,Using = "txtAddress")]
        private IWebElement TextAddress { get; set; }

        [FindsBy(How = How.XPath,Using = "(//input[@name='cmdSubmit'])[3]")]
        private IWebElement SubmitButton { get; set; }


        public Checkout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void CustomerBilling(string Vname, string Vaddress)
        {
            TextName.SendKeys(Vname);
            TextAddress.SendKeys(Vaddress);
        }

        public void CustomerShipping()
        {
            // Do this as assignment
        }

        public void ClickSubmit()
        {
            SubmitButton.Click();
        }

        /*
        driver.FindElement(By.Name("txtCustomerName")).SendKeys("Tim Short");
        driver.FindElement(By.Name("txtAddress")).Clear();
        driver.FindElement(By.Name("txtAddress")).SendKeys("123 Main St");
        driver.FindElement(By.Name("txtCity")).Clear();
        driver.FindElement(By.Name("txtCity")).SendKeys("Chicago");
        driver.FindElement(By.Name("txtState")).Clear();
        driver.FindElement(By.Name("txtState")).SendKeys("IL");
        driver.FindElement(By.Name("txtZIP")).Clear();
        driver.FindElement(By.Name("txtZIP")).SendKeys("45456");
        driver.FindElement(By.Name("txtPhone")).Clear();
        driver.FindElement(By.Name("txtPhone")).SendKeys("8887863033");
        driver.FindElement(By.Name("optPaymentType")).Click();
        driver.FindElement(By.Name("txtAcctNo")).Clear();
        driver.FindElement(By.Name("txtAcctNo")).SendKeys("4123123412341234");
        driver.FindElement(By.Name("txtCVV2No")).Clear();
        driver.FindElement(By.Name("txtCVV2No")).SendKeys("123");
        driver.FindElement(By.Name("txtExpDate")).Clear();
        driver.FindElement(By.Name("txtExpDate")).SendKeys("12/2020");
        driver.FindElement(By.Name("txtshipCustomerName")).Clear();
        driver.FindElement(By.Name("txtshipCustomerName")).SendKeys("Tim Short");
        driver.FindElement(By.Name("txtshipAddress")).Clear();
        driver.FindElement(By.Name("txtshipAddress")).SendKeys("123 Main St");
        driver.FindElement(By.Name("txtshipCity")).Clear();
        driver.FindElement(By.Name("txtshipCity")).SendKeys("Chicago");
        driver.FindElement(By.Name("txtshipState")).Clear();
        driver.FindElement(By.Name("txtshipState")).SendKeys("IL 4");
        driver.FindElement(By.Name("txtshipState")).Clear();
        driver.FindElement(By.Name("txtshipState")).SendKeys("IL");
        driver.FindElement(By.Name("txtshipZIP")).Clear();
        driver.FindElement(By.Name("txtshipZIP")).SendKeys("45456");
        driver.FindElement(By.Name("txtshipPhone")).Clear();
        driver.FindElement(By.Name("txtshipPhone")).SendKeys("8887863033");
        */
    }
}

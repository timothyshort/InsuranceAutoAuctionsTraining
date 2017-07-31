using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject01.Helpers;
using TestingProject01.Pages;

namespace TestingProject01.Tests
{
    class ShoppingCart
    {
        private IWebDriver driver;
        private string baseURL;

        [SetUp]
        public void SetupTest()
        {
            baseURL = "http://sdettraining.com/";
            driver = Browser.NewBrowser("IE", baseURL);
            driver.Navigate().GoToUrl(baseURL + "/projects/");
            driver.FindElement(By.LinkText("Shopping Cart Application")).Click();
        }
        [Test]
        public void ShoppingCartTest()
        {
            // Home Page: access methods directly (static)
            HomePage.SearchItem(driver, "iPhone");
            HomePage.ClickSearch(driver);

            // Add to Cart Page Object
            AddtoCart oAdd = new AddtoCart();
            oAdd.Add(driver, "btnApple_Iphone_6.jpg");

            // Modify Cart
            var ModifyCart = new ModifyCart(driver);
            ModifyCart.UpdateCart("6");

            // Checkout: Checkout Object using Page Factory
            var oCheckoutPage = new Checkout(driver);
            oCheckoutPage.CustomerBilling("Timothy Short", "123 Main Street");
            oCheckoutPage.CustomerShipping();
            oCheckoutPage.ClickSubmit();
            
            string Confirmation = driver.FindElement(By.CssSelector("body > font")).Text;
            Capture.Screenshot(driver, "Output","ShoppingCartTest");
        }
    }
}

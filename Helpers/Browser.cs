using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

public class Browser
{

    public static void CloseWindows(IWebDriver driver, string criteria)
    {
        // code to close alternate popups
    }

    public static IWebDriver NewRandomBrowser()
    {
        Random r = new Random();
        int rInt = r.Next(1, 3);
        IWebDriver driver;
        switch (rInt)
        {
            case 1:
                driver = new FirefoxDriver();
                break;
            case 2:
                // code for IE Driver
            case 3:
                // code for Chrome Driver
            default:
                driver = new FirefoxDriver();
                break;
        }
        return driver;
    }

    public static IWebDriver NewBrowser(string browserType, string url)
    {
        IWebDriver driver;

        if (browserType.ToUpper().Equals("CHROME"))
        {
            driver = new ChromeDriver();
        }
        else if (browserType.ToUpper().Equals("FIREFOX"))
        {
            driver = new FirefoxDriver();
        }
        else if (browserType.ToUpper().Equals("IE"))
        {
            driver = new InternetExplorerDriver();
        }
        else
        {
            driver = new FirefoxDriver();
        }
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
        return driver;
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject01.Helpers
{
    class Capture
    {
        public static void Screenshot(IWebDriver driver, string path, string name)
        {
            string filepath = @"C:\Users\owner\Documents\visual studio 2015\Projects\TestingProject01\TestingProject01\";
            if (path != "") {
                filepath = filepath + path + @"\";
            }
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(filepath  + name + ".jpg", ScreenshotImageFormat.Jpeg);

        }
    }
}

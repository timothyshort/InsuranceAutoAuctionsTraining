using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestingProject01.Configs
{
    class GlobalSettings
    {
        // Variables declared as outlined in GlobalConfigSettings.xml
        public static string MainURL;
        public static string BrowserType;
        public static string BrowserCache;
        public static string BrowserCookies;
        public static string DataSourceType;
        public static string DataSourceFile;
        public static string DataSourceTableName;
        public static string DataSourceField1;
        public static string DataSourceField2;
        public static string DataSourceField3;
        public static string DataSourceField4;

        public static void GetGlobalData()
        {
            /*
            // Connect to XML Configuration File
            string fileLocation = @"C:\Users\owner\Documents\Visual Studio 2015\Projects\TestingProject01\TestingProject01\DataSources\Configs\GlobalConfigSettings.xml";
            FileStream fileStream = new FileStream(fileLocation, FileMode.Open);

            // Convert file to XPath readable and use XPath navigator to find specifc nodes
            XPathDocument xDoc = new XPathDocument(fileStream);
            XPathNavigator xNav = xDoc.CreateNavigator();

            // Define XPath items by nodes using the navigator
            XPathItem mainURL = xNav.SelectSingleNode("TestFramework/Settings/MainURL");
            XPathItem browserType = xNav.SelectSingleNode("TestFramework/BrowserSettings/Type");
            XPathItem browserCache = xNav.SelectSingleNode("TestFramework/BrowserSettings/Cache");
            XPathItem browserCookies = xNav.SelectSingleNode("TestFramework/BrowserSettings/Cookies");
            XPathItem dataSourceType = xNav.SelectSingleNode("TestFramework/DataSettings/Type");
            XPathItem dataSourceTable = xNav.SelectSingleNode("TestFramework/DataSettings/Table");
            XPathItem dataSourceField1 = xNav.SelectSingleNode("TestFramework/DataSettings/Field1");
            XPathItem dataSourceField2 = xNav.SelectSingleNode("TestFramework/DataSettings/Field2");
            XPathItem dataSourceField3 = xNav.SelectSingleNode("TestFramework/DataSettings/Field3");
            XPathItem dataSourceField4 = xNav.SelectSingleNode("TestFramework/DataSettings/Field4");
            XPathItem dataSourceFile = xNav.SelectSingleNode("TestFramework/DataSettings/Source");

            // Convert XPath item to public string variable
            MainURL = mainURL.ToString();
            BrowserType = browserType.ToString();
            BrowserCache = browserCache.ToString();
            BrowserCookies = browserCache.ToString();
            DataSourceType = dataSourceType.ToString();
            DataSourceTableName = dataSourceTable.ToString();
            DataSourceField1 = dataSourceField1.ToString();
            DataSourceField2 = dataSourceField2.ToString();
            DataSourceField3 = dataSourceField3.ToString();
            DataSourceField4 = dataSourceField4.ToString();
            DataSourceFile = dataSourceFile.ToString();
            */
        }
    }
}

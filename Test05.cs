using log4net;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestingProject01.DataReaders;


/* Test Project #5 - Creating a Framework
 * New Browser from Browser Class
 * Read CSV from File class (and parse into Lists)
 * Read txt from File class
 * Take Screenshot from Capture Class
 * Write to Log from Log CLass
 * Add Folders to namespaces to remove folder prefix
 */

namespace TestingProject01
{
    class Test05
    {
        List<string> firstnames = new List<string>();
        List<string> lastnames = new List<string>();
        List<string> emails = new List<string>();
        int size;

        [SetUp]
        public void SetUp()
        {
            // Call Browser.NewBrowser(browserType, Url)
            
            // Call CSVReader
            List<string[]> DataTable = DataReaders.File.GetCSV(@"TestData.csv");
            size = DataTable.Count();
            foreach (string[] datarow in DataTable)
            {
                firstnames.Add(datarow[0]);
                lastnames.Add(datarow[1]);
                emails.Add(datarow[2]);
            }

            // Call TextReader
            List<string> data = DataReaders.File.GetTxt(@"TextData.txt");
            foreach (string sample in data)
            {
                Console.WriteLine(sample);
            }

            // Write to Log
            ILog logfile = Helpers.Log.LogMsg ("NewUserTest");
            logfile.Warn("Starting Test");
            logfile.Info("New test");

        }
        
        [Test]
        public void TestFramework()
        {
            // Execute test
            // Call Capture.Screenshot(driver, folder, filename)
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("***");
                Console.Write(firstnames[i]);
                Console.Write(lastnames[i]);
                Console.Write(emails[i]);
                Console.WriteLine();
            }
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Test Project #7 - Data from Excel
 * Calls Database.Get
 * Configs based on XML file
 * Initialize configus using Config.class
 * Takes the Query
 */

namespace TestingProject01
{
    class Test08
    {
        [Test]
        public void SetUp()
        {
            string xlFile = @"MasterTestCases.xlsx";
            string xlSheet = "NewUsers";
            DataTable xlData = DataReaders.Excel.Get(xlFile, xlSheet);

            // local variables to store data from Excel
            string firstName;
            string lastName;
            string email;
            string homephone;

            foreach (DataRow dataRow in xlData.Rows)
            {
                // Grab element in given row as defined by the data source field
                firstName = dataRow["firstname"].ToString().Trim();
                lastName = dataRow["lastname"].ToString().Trim();
                email = dataRow["email"].ToString().Trim();
                homephone = dataRow["homephone"].ToString().Trim();

                Console.WriteLine("*****************");
                Console.WriteLine("Field 1: " + firstName);
                Console.WriteLine("Field 2: " + lastName);
                Console.WriteLine("Field 3: " + email);
                Console.WriteLine("Field 4: " + homephone);
            }
        }
    }
}

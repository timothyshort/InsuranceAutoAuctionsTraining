using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NUnit.Framework;

/* Test Project #7 - Data from Database
 * Calls Database.Get
 * Takes the Query
 */

namespace TestingProject01
{
    class Test07
    {
        [Test]
        public void TestwithDB()
        {
            string vLenderLoanNumber;
            string vSellerNumber;
            string vFinancialInstitutionNumber;
            string vMortgageDate;

            DataTable dbData = DataReaders.Database.Get("Select * from MortgageLoanTestData");

            foreach (DataRow oDataRow in dbData.Rows)
            {
                vLenderLoanNumber = oDataRow["LenderLoanNumber"].ToString().Trim();
                vSellerNumber = oDataRow["SellerNumber"].ToString().Trim();
                vFinancialInstitutionNumber = oDataRow["FinancialInstitutionNumber"].ToString().Trim();
                vMortgageDate = oDataRow["DateOfMortgageNote"].ToString().Trim();

                Console.WriteLine("******************************");
                Console.WriteLine("Lender Loan Number: " + oDataRow["LenderLoanNumber"].ToString().Trim());
                Console.WriteLine("Seller Number: " + oDataRow["SellerNumber"].ToString().Trim());
                Console.WriteLine("Financial Institution Number: " + oDataRow["FinancialInstitutionNumber"].ToString().Trim());
                Console.WriteLine("Mortgage Date: " + oDataRow["DateOfMortgageNote"].ToString().Trim());
            }
        }
    }
}

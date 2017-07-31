using System;
using System.Data;
using System.Data.OleDb;

namespace TestingProject01.DataReaders
{
    class Excel
    {
        private static string RootDirectory = @"C:\Users\owner\Documents\Visual Studio 2015\Projects\TestingProject01\TestingProject01\DataSources\";

        public static DataTable Get(string excelFilePath, string sheetName)
        {
            /*
             * This function returns a DataTable
             * Filepath and Sheetname are passed into function
             */

            // if SheetName is not provided, it is set to the default Excel sheet name of Sheet1
            string dir = RootDirectory;
            if (sheetName == "") { sheetName = "Sheet1"; }

            // Install https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734

            // Intialize settings
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dir + excelFilePath + ";Extended Properties='Excel 12.0 Xml;HDR=Yes:IMEX=10;'";
            Console.WriteLine("Excel File: " + excelFilePath);
            Console.WriteLine("Excel Sheet: " + sheetName);
            Console.WriteLine("Connection String: " + connectionString);

            DataTable localDataTable = new DataTable();
            using (OleDbConnection oConnection = new OleDbConnection(connectionString))
            {
                Console.WriteLine("Openning connection");
                oConnection.Open();

                Console.WriteLine("Command");
                OleDbCommand oCommand = new OleDbCommand();
                oCommand.Connection = oConnection;

                DataTable oDataSheet = oConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                foreach (DataRow oRow in oDataSheet.Rows)
                {
                    oCommand.CommandText = "Select * from [" + sheetName + "$]";
                    OleDbDataAdapter oDataAdapter = new OleDbDataAdapter(oCommand);
                    oDataAdapter.Fill(localDataTable);
                }
                oCommand = null;
                oConnection.Close();
            }
            return localDataTable;
        }

        public static void Write()
        {
            // code to write to excel
        }
    }
}

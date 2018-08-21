using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TestingProject01.DataReaders
{
    class Database
    {
        public static DataTable Get(string QueryString)
        {
            /*
             * This function returns a DataTable
             * Connection String is defined in the App.config file
             * Query is passed into function
             * Requires installing using System.Data.Common Namespace
             */

            // Connection String: server, user, password, database
            string serverName = ConfigurationSettings.AppSettings["server"].ToString();
            string username = ConfigurationSettings.AppSettings["login"].ToString();
            string password = ConfigurationSettings.AppSettings["password"].ToString();
            string database = ConfigurationSettings.AppSettings["database"].ToString();
            string connectionString = "server=" + serverName + ";User=" + username + ";Password=" + password + ";database=" + database + ";";
            Console.WriteLine("Connection String: " + connectionString);

            // Query
            string sqlQuery = QueryString;

            // Prepared Statements
            // 1. Connect to DB
            SqlConnection oConnection = new SqlConnection(connectionString);
            // 2. Execute Query and Read Result
            SqlCommand oCommand = new SqlCommand(sqlQuery, oConnection);
            // 3. Create Data Reader
            SqlDataReader oDataReader;
            // 4. Create Useable Table
            DataTable dtbl = new DataTable();

            // Executing Prepared Statements
            oConnection.Open();
            oDataReader = oCommand.ExecuteReader();
            dtbl.Load(oDataReader);
            return dtbl;
        }
    }
}

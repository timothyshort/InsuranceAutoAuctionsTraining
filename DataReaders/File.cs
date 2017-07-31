using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace TestingProject01.DataReaders
{
    class File
    {
        private static string RootDirectory = @"C:\Users\owner\Documents\Visual Studio 2015\Projects\TestingProject01\TestingProject01\DataSources\";

        public static List<string> GetTxt(string file)
        {
            List<string> fileData = new List<string>();
            string element;
            string dir = RootDirectory;

            StreamReader sr = new StreamReader(dir + file);
            while ((element = sr.ReadLine()) != null)
            {
                fileData.Add(element);
            }
            sr.Close();
            return fileData;
        }

        public static List<string[]> GetCSV(string file)
        {
            List<string[]> fileData = new List<string[]>();
            string row;
            string dir = RootDirectory;

            try
            {
                StreamReader sr = new StreamReader(dir + file);

                while ((row = sr.ReadLine()) != null)
                {
                    string[] elements = Regex.Split(row, ",");
                    fileData.Add(elements);
                }
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.Write("File is not found" + e.Message);

            }
            return fileData;
        }

        public static void WritetoTxt(string file, string[] dataSource)
        {
            string path = ConfigurationSettings.AppSettings["rootdir"].ToString();
            string filename = path + file;
            using (StreamWriter writetext = new StreamWriter(filename))
            {
                foreach (string data in dataSource)
                    writetext.WriteLine(data);
            }
        }

        public static void WritetoTxt(string file, List<string>dataSource)
        {
            string path = ConfigurationSettings.AppSettings["rootdir"].ToString();
            string filename = path + file;
            using (StreamWriter writetext = new StreamWriter(filename))
            {
                foreach (string data in dataSource)
                writetext.WriteLine(data);
            }
        }
    }
}

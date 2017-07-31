using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestingProject01.Helpers
{
    class Log
    {
        private static ILog LogFile;

        private static void Initialize(string testName)
        {
            log4net.Config.XmlConfigurator.Configure();
            LogFile = LogManager.GetLogger(testName);
        }

        public static ILog LogMsg(string testName)
        {
            log4net.Config.XmlConfigurator.Configure();
            LogFile = LogManager.GetLogger(testName);
            return LogFile;
        }

        public static void Warn(string testName, string message)
        {
            Initialize(testName);
            LogFile.Warn(message);
        }
        public static void Info(string testName, string message)
        {
            Initialize(testName);
            LogFile.Info(message);
        }
        public static void Error(string testName, string message)
        {
            Initialize(testName);
            LogFile.Error(message);
        }

        
    }
}

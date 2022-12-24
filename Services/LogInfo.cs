using System;
using System.Text;
using System.IO;


namespace Services
{
     class LogInfo : ELogInfo 
    {
        static string logName = "log.txt";

        public static void LogServiceAction(string _name, Action _action)
        {
            string logData =
                string.Format("Service {0} was {1} at {2}"
                    , _name
                    , _action.ToString()
                    , DateTime.Now.ToString("dd-MM-yy: hh-mm-ss")
                );

            using (StreamWriter sw = new StreamWriter(logName, true, Encoding.Default))
            {
                sw.WriteLine(logData);
                sw.Close();
            }

        }

        public static void LogServiceChangeMode(string _name, ServiceMode _mode)
        {
            string logData =
                string.Format("Service {0} was set to mode {1} at {2}"
                    , _name
                    , _mode.ToString()
                    , DateTime.Now.ToString("dd-MM-yy: hh-mm-ss")
                );

            using (StreamWriter sw = new StreamWriter(logName, true, Encoding.Default))
            {
                sw.WriteLine(logData);
                sw.Close();
            }
        }

    }
}

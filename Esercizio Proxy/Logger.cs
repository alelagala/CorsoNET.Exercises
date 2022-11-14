using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Proxy
{
    internal class Logger
    {
        static Logger _instance;
        public static string currentDir;
        public static string logFileName;

        Logger()
        {
            currentDir = Environment.CurrentDirectory;
            logFileName = "Log.txt";
            StringBuilder sb = new StringBuilder();
            if (!File.Exists(Path.Combine(currentDir, logFileName)))
            {
                sb.AppendLine("Log of user connections");
                File.AppendAllText(Path.Combine(currentDir, logFileName), sb.ToString());
            }
        }
        public static Logger getInstance()
        {
            if(_instance==null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public static void Log(User user,int connectionType)
        {
            StringBuilder sb = new StringBuilder();            
            string connection;
            if(connectionType == 1){connection = "Connected";}
            else{connection = "Disconnected";}
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            sb.AppendLine($"User {user.Username} with ip: {user.IP} at {timestamp} {connection}");
            File.AppendAllText(Path.Combine(currentDir, logFileName), sb.ToString());
        }








    }
}

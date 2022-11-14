using System;
using System.Text;
using System.IO;
using System.Globalization;

namespace Log_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Ciao");

        }
    }







    public static class Logger
    {
        public static string currentDir= Environment.CurrentDirectory;
        public static string logFileName = "Log.txt";

        public static void Log(string log)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(currentDir);
            if (!File.Exists(Path.Combine(currentDir, logFileName))){
                sb.AppendLine("Log info - Issued at");
                File.AppendAllText(Path.Combine(currentDir,logFileName), sb.ToString());
            }
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            sb.AppendLine($"{log}-{timestamp}");
            File.AppendAllText(Path.Combine(currentDir,logFileName), sb.ToString());    
        }
    }
}

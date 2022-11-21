using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Config_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();
            Settings settings = config.GetRequiredSection("settings").Get<Settings>();
            EmailService.ConfigureMail(settings.SMTP, settings.POP,settings.HTTP,settings.COMPANY);
            Console.WriteLine(settings.SMTP);
            EmailService.SendMail(settings.SMTP, settings.POP);
            
        }
    }


    public class EmailService
    {
        static Server _server;
        
        public static void ConfigureMail(string SMTP, string POP,string HTTP,string COMPANY)
        {
            _server = new Server(SMTP, POP, HTTP, COMPANY);
        }
        public static void SendMail(string Msg, string POP)
        {
            _server.SendMail(Msg);
        }
        class Server
        {
            string _POP;
            string _SMTP;
            string _HTTP;
            string _COMPANY;
            public Server(string SMTP, string POP, string HTTP, string COMPANY)
            {
                this._POP = POP;
                this._SMTP = SMTP;
                this._HTTP = HTTP;
                this._COMPANY = COMPANY;
            }

            public void SendMail(string Msg)
            {
                Console.WriteLine($"Sending mail with {Msg},");
            }
            public void ShowSender(string sender)
            {
                Console.WriteLine($"Message sent by {sender}");
            }
        }

    }
    public class Settings
    {
        public string SMTP { get; set; }
        public string POP { get; set; }

        public string HTTP { get; set; }

        public string COMPANY { get; set; }

        
    }




}

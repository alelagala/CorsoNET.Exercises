using System;
using System.Collections.Generic;
using System.IO;

namespace Esercizio_Logs_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person alex = new("Alex","Rossi");
            Account account1 = new Account("Bancomat", 374908276);
            Log(alex);
            Log(account1);
        }




        public static void Log<T>(T item) where T : class
        {
            var properties= item.GetType().GetProperties();
            var itemName = item.GetType().Name;
            string path = Path.Combine(Environment.CurrentDirectory,$"{itemName}.txt");
            if (!File.Exists(path))
            {
                foreach(var property in properties)
                {
                    File.AppendAllText(path, property.Name);
                    File.AppendAllText(path, " ");
                }
            }
            File.AppendAllText(path,"\n");
            foreach(var property in properties)
            {
                //File.AppendAllText(path, property.GetValue());
                               
                File.AppendAllText(path, property.GetValue(item).ToString());
                File.AppendAllText(path, " ");
            }
            File.AppendAllText(path, "\n");
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public Person(string name,string surname)
        {
            Name = name;
            Surname= surname;
        }
    }
    
    public class Account
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Account(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }












}

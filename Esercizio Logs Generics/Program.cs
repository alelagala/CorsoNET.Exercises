using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Esercizio_Logs_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person alex = new() { Name="Alex",Surname="Rossi"};
            Account account1 = new() { Name="Bancomat", Id=374908276 };

            string path = Path.Combine(Environment.CurrentDirectory, $"{alex.GetType().Name}.csv");
            List<Person> list = new List<Person>();
            Log(alex);
            Log(account1);
            list=LoadFromFile<Person>(path);

        }

        public static void Log<T>(T item) where T : class
        {
            var properties= item.GetType().GetProperties();
            var itemName = item.GetType().Name;
            string path= Path.Combine(Environment.CurrentDirectory, $"{itemName}.csv");
            
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
            //File.AppendAllText(path, "\n");
        }
    
        public static List<T> LoadFromFile<T>(string path) where T: class, new()
        {
            List<T>output = new List<T>();
            var lines = File.ReadAllLines(path).ToList();            
            T entry=new();
            string[] headers= lines[0].Split(';');
            lines.RemoveAt(0);
            int i;
            if (checkType(entry, path))
            { 
                foreach (var line in lines)
                {
                    i = 0;
                    string[] values = line.Split(';');
                    entry = new T();
                    foreach (var value in values)
                    {
                        //var converted = Convert.ChangeType(value, entry.GetType().GetProperty(headers[i]).PropertyType);
                        entry.GetType().GetProperty(headers[i]).SetValue(entry, Convert.ChangeType(value, entry.GetType().GetProperty(headers[i]).PropertyType));
                        i++;
                    }
                    output.Add(entry);
                }
            }
            else { Console.WriteLine("File non compatibile"); }
            return output;
        }


        public static bool checkType<T>(T item, string path) where T:class,new()
        {
            string[] headers = File.ReadAllLines(path).ToList()[0].Split(';');
            foreach(string header in headers)
            {
                if (item.GetType().GetProperty(header) == null)
                {
                    return false;
                }
            }
            return true;
        }    
    }


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public Person()
        {
        }
    }
    
    public class Account
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Account()
        {
        }
    }












}

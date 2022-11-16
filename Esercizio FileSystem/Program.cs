using Esercizio_FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Esercizio_FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>() { new Person("Ale","La Gala",25),new Person("Marco","Sabato",89) };
            List<Account> accounts = new List<Account>() { new Account(928, "BancoPosta"), new Account(2873, "Postepay") };
            WriteOnFile(persons);
            WriteOnFile(accounts);

            





        }
        public static void WriteOnFile<T>(List<T> list)
        {
            string current = Environment.CurrentDirectory;
            StringBuilder sb = new StringBuilder();
            if (list is List<Person>)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    var person = list[i] as Person;
                    sb.Clear();
                    sb.AppendLine($"Name:{person.Name}, Surname:{person.Surname},Age:{person.Age}");
                    File.AppendAllText(Path.Combine(current, "persons.txt"), sb.ToString());
                }                
            }
            else if (list is List<Account>)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var account = list[i] as Account;
                    sb.Clear();
                    sb.AppendLine($"Account id:{account.Id}, Account name:{account.Name}");
                    File.AppendAllText(Path.Combine(current, "accounts.txt"), sb.ToString());
                }
            }
        }

        public static void WritePerson(Person person)
        {
            
            StringBuilder sb = new StringBuilder();
            
        }
        public static void WriteAccount(Account account)
        {
            string current = Environment.CurrentDirectory;
            StringBuilder sb = new StringBuilder();
            
        }



    }

    


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }   
    }

    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Account(int id,string name)
        {
            Id = id;
            Name= name;
        }
    }









}

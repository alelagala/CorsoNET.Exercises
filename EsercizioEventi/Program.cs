using System;

namespace EsercizioEventi
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            CommercialBank commercialBank = new CommercialBank();
            commercialBank._CEO = "Alex";
            commercialBank.nameChanged += new CEOEventHandler(NameChanged);
            commercialBank._CEO = "Ale";
            commercialBank._CEO = "Marco";

        }


        public static void NameChanged(object sender, CEOEventArgs e)
        {
            Console.WriteLine($"Hello {sender.GetType().Name}, il nuovo CEO è {e.newName}");
        }

    }


    

    

   





















}

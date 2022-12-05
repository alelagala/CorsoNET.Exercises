using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;
using System.Xml.Linq;

namespace Esercizio_DelegatesP2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Country italy=new Country() { Name="Italy", positives=0};
            Country france=new Country() { Name = "France", positives = 0};
            Country germany=new Country() { Name = "Germany", positives = 0};
            Country ireland = new Country() { Name = "Ireland", positives = 0 };            

            italy.changedPositives += new CovidEventHandler(OnChangedPositives);
            france.changedPositives += new CovidEventHandler(OnChangedPositives);
            germany.changedPositives += new CovidEventHandler(OnChangedPositives);
            ireland.changedPositives += new CovidEventHandler(OnChangedPositives);

            EU.CountryList.Add(italy);
            EU.CountryList.Add(germany);
            EU.CountryList.Add(france);
            EU.CountryList.Add(ireland);

            SetRandomNumber(italy);
            SetRandomNumber(germany);


            


        }

        public static void OnChangedPositives(object sender, CovidEventArgs e)
        {
            if (e.newAmount < 0)
            {
                Console.WriteLine($"Il paese {sender.GetType().GetProperty("Name").GetValue(sender)} ha ora 0 positivi");
            }
            else { Console.WriteLine($"Il paese {sender.GetType().GetProperty("Name").GetValue(sender)} ha ora {e.newAmount} positivi"); }
            int result = 0;
            foreach (Country country in EU.CountryList)
            {
                result += country.positives;
            }
            if (result < 0) result = 0;
            EU.totalPositives = result;
            
            Console.WriteLine($"Ora in EU ci sono {EU.totalPositives} positivi");

        }

        public static void SetRandomNumber(Country country)
        {
            Random random = new Random();
            country.positives = random.Next(-5000, 10000);  
        }


        
    }






}

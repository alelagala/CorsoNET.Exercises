using System.Collections.Generic;

namespace Esercizio_DelegatesP2
{
    public static class EU
    {
        public static List<Country> CountryList = new List<Country>();
        public static int totalPositives { get; set; }
        
        public static void CountPositives()
        {
            int result = 0;
            foreach(Country country in CountryList)
            {
                result += country.positives;
            }
            totalPositives=result;
        }

    }






}

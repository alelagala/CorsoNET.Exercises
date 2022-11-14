using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurozone.Country
{
    public class City
    {
        public string name;
        public Country belongingCountry;
        public List<Citizen> citizens;

        public City(string name,Country country)
        {
            this.name = name;
            this.belongingCountry = country;
        }


        public void addCitizen(Citizen newCitizen)
        {
            if (citizens.IndexOf(newCitizen) == -1)
            {
                citizens.Add(newCitizen);
            }
        }






    }
}

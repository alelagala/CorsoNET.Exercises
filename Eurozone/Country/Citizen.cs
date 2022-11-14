using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurozone.Country
{
    public class Citizen
    {
        public string _name;
        public string _surname;
        public City city;

        public Citizen(string name, string surname, City city)
        {
            _name = name;
            _surname = surname;
            this.city = city;
        }
    }
}

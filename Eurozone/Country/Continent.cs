using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurozone.Country
{
    public class Continent
    {
        protected List<Country> _countries;
        protected string _name;

        public Continent(string name)
        {
            _countries = new List<Country>();
            _name = name;
        }

        public void addCountry(Country newCountry)
        {
            if (_countries.IndexOf(newCountry) == -1 && newCountry.continente.ToLower() == this._name.ToLower())
            {
                this._countries.Add(newCountry);
            };
        }
        public void removeCountry(Country countryToRemove)
        {
            if (_countries.IndexOf(countryToRemove) != -1)
            {
                this._countries.Remove(countryToRemove);
            }
        }

    }
}

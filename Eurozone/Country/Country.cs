using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurozone.Country
{
    public class Country : Territory
    {
        protected string costituzione;
        protected string bandiera;
        protected string moneta;
        protected string linguaUfficiale;
        protected float pil;
        protected bool penaMorte;
        protected string nome;
        public List<City> cities;

        public Country(int popolazione, float areaGeografica, string continente, string _nome, string _costituzione, string _bandiera, string _moneta, string _linguaUfficiale, float _pil, bool _penaMorte) : base(popolazione, areaGeografica, continente)
        {
            nome = _nome;
            costituzione = _costituzione;
            bandiera = _bandiera;
            moneta = _moneta;
            linguaUfficiale = _linguaUfficiale;
            pil = _pil;
            penaMorte = _penaMorte;
            cities = new List<City>();
            
        }
        public void addCity(City newCity)
        {
            if (cities.IndexOf(newCity) == -1)
            {
                cities.Add(newCity);
            }
        }
    }
}



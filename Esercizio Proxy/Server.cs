using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Proxy
{
    public class Server
    {
        private string _name;

        public Server(string name)
        {
            _name = name;
        }

        public void Access(User utente)
        {
            Console.WriteLine($"Ti sei connesso con questo IP: {utente.IP}");
        }
        public void Deconnect(User utente)
        {
            Console.WriteLine($"Ti sei disconnesso con questo IP:{utente.IP}");
        }
    }
}

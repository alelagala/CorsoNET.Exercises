using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioEventi
{
    public delegate void CEOEventHandler(object sender, CEOEventArgs e);
    public class CEOEventArgs : EventArgs
    {
        public string newName;
        public bool cancel;
        public CEOEventArgs(string newName)
        {
            this.newName = newName;
        }
    }
}

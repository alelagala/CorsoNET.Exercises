using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioEventi
{
    public abstract class CentralBank
    {
        public event CEOEventHandler nameChanged;
        public string CEO;
        public string _CEO
        {
            get { return CEO; }
            set
            {
                if (CEO != value)
                {
                    if (nameChanged != null)
                    {
                        CEOEventArgs ceoEventArgs = new CEOEventArgs(value);
                        nameChanged(this, ceoEventArgs);
                        CEO = value;
                    }
                }

            }
        }
    }
    public class CommercialBank: CentralBank
    {
        

    }

    public class CryptoBank : CommercialBank
    {
        
    }
}

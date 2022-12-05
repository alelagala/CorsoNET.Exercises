using System;

namespace Esercizio_DelegatesP2
{
    public delegate void CovidEventHandler(object sender, CovidEventArgs e);
    public class CovidEventArgs : EventArgs
    {
        public int newAmount;
        public CovidEventArgs(int newAmount)
        {
            this.newAmount = newAmount;
        }
    }






}

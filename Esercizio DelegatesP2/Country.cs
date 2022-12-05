namespace Esercizio_DelegatesP2
{
    public class Country
    {
        public string Name { get; set; }
        private int Positives;
        public event CovidEventHandler changedPositives;
        public int positives
        { 
            get { return Positives; }
            set
            {
                if(Positives != value)
                {
                    CovidEventArgs e = new CovidEventArgs(value);
                    Positives = value;
                    changedPositives(this, e);
                }
            }
        }


    }







}

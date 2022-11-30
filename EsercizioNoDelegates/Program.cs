using System;

namespace EsercizioNoDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Account account = new Account() { Country="EN" };

            ItalianATM atmBari = new ItalianATM();

            atmBari.NationalWithdraw(account, 500);

        }
    


    public interface INationalAccount: IInternationalAccount
    {
        public void Deposit(Account account, int amount);
        public decimal GetInterests(Account account);

    }
    public interface IInternationalAccount
    {
        public void NationalWithdraw(Account account, int amount);
    }

    public class Account:INationalAccount
    {
        public string Country { get; set; }
        public void NationalWithdraw(Account account,int amount)
        {
            Console.WriteLine($"Hai prelevato ${amount} dal tuo account");
        }
        public void InternationalWithdraw(IInternationalAccount account, int amount)
        {
            Console.WriteLine($"Hai prelevato ${amount} da una banca estera");

        }
        public virtual void Deposit(Account account, int amount) { }
        public virtual decimal GetInterests(Account account) { return 0; }
    }

    public abstract class ATM : INationalAccount
    {
        public virtual void Deposit(Account account, int amount) { }
        public virtual decimal GetInterests(Account account){return 0;}
        public virtual void NationalWithdraw(Account account, int amount) { }
        
    }
    public class ItalianATM : ATM, INationalAccount
    {
        public string Country = "IT";
        public override void Deposit(Account account,int amount) { }
        public override decimal GetInterests(Account account) { return new Random().Next(); }
        public override void NationalWithdraw(Account account,int amount)
        {
            if (account.Country == this.Country)
            {
                account.NationalWithdraw(account, amount);
            }
            else
            {
                IInternationalAccount newAccount = (IInternationalAccount)account;
                account.InternationalWithdraw(newAccount, amount);  
            }
        }
    }








    

    }

}

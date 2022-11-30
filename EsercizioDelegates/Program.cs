using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace EsercizioDelegates
{
    public delegate void WithdrawAction(int amount);
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account() { Balance = 15000, Country = "Italy", Owner = "Alessandro" };
            Account account2 = new Account() { Balance = 300000, Country = "England", Owner = "James" };
            Bank ISP = new Bank("Intesa san Paolo", "Italy");
            ItalianATM atmBari = new ItalianATM() { Country = "Italy", Address = "Via guido d'orso" };
            ISP.AddAccount(account1);
            ISP.AddAccount(account2);
            ISP.ManageWithdraw(atmBari, account2, 300);



        }




        public class Bank
        {
            public string Name { get; set; }
            public string Country { get; set; }

            public List<Account> accounts= new List<Account>();

            public Bank(string _name, string _country)
            {
                Name = _name;
                Country = _country;
                accounts = new List<Account>();
            }
            public void AddAccount(Account account)
            {
                accounts.Add(account);
            }

            public void ManageWithdraw(IATM atm, Account account, int amount)
            {
                if (CheckCountry(atm, account) && BelongsToBank(account))
                {
                    atm.NationalWithdraw(amount, account);
                }
                else
                {
                    WithdrawAction withdrawal = account.Withdraw;
                    atm.InternationalWithdraw(amount, withdrawal);
                }
            }

            public  bool BelongsToBank(Account account)
            {
                if (accounts.Contains(account))
                {
                    return true;
                }
                return false;
            }
            public static bool CheckCountry(IATM atm, Account account)
            {
                if (atm.Country == account.Country)
                {
                    return true;
                }
                return false;
            }
        }



        public class Account
        {
            public string Owner { get; set; }
            public string Country { get; set; }
            public decimal Balance { get; set; }

            public void Withdraw(int amount)
            {
                Balance -= amount;
            }
            public void Deposit(int amount)
            {
                Balance += amount;
            }
            public decimal CalculateInterests()
            {
                Random random = new Random();
                return Balance * random.Next(1, 3 / 2);
            }
        }


        public abstract class IATM
        {
            public virtual void NationalWithdraw(int amount, Account account) { }
            public virtual void InternationalWithdraw(int amount, WithdrawAction account) { }

            public string Country;

            public string Address;
        }


        public class ItalianATM : IATM
        {

            public override void NationalWithdraw(int amount, Account account)
            {
                Console.WriteLine($"Hai prelevato {amount} euro");
                account.Withdraw(amount);
            }
            public override void InternationalWithdraw(int amount, WithdrawAction account)
            {
                Console.WriteLine($"Hai prelevato {amount} euro dall'estero");
                account(amount);
            }
        }
    }
}
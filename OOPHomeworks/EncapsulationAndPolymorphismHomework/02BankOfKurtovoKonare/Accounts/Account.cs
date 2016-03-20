using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Interfaces;

namespace _02BankOfKurtovoKonare.Accounts
{
    public class Account : IAccount
    {
        protected decimal balance;
        protected Customer customer;
        private int mounth;
        private double interestRate;

        public Account(Customer customer, decimal balance, double interesRateInPercent, int mounth)
        {
            this.Balance = balance;
            this.Customer = customer;
            this.InterstRate = interesRateInPercent;
            this.Mounth = mounth;
           CalculateInterest(mounth);
            
        }
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double InterstRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value / 100; }
        }
        public int Mounth 
        {
            get { return this.mounth; }
            set { this.mounth = value; }
        }

        public void AddMoneyToBankStatus(decimal money)
        {
            this.balance += money;
            if (money != 0)
            {
                 CalculateInterest(Mounth);
            }
           
        }

        public void RemoveMoneyFromBankStatus(decimal money)
        {
            this.balance -= money;
            if (money !=  0)
            {
                CalculateInterest(Mounth);
            }
        }

        public virtual decimal CalculateInterest(int mounts)
        {
            decimal interest = balance * (1 + (decimal)InterstRate * mounts);
            balance = interest;
            return balance;
        }

        public override string ToString()
        {
            return string.Format("Account type: {0}\nCustomer: {1}\nBalance: {2:F2}\nInterest Rate: {3}%\nMounths : {4}\n" , this.GetType().Name , this.Customer , this.Balance , this.InterstRate * 100 , this.Mounth );
        }
    }
}

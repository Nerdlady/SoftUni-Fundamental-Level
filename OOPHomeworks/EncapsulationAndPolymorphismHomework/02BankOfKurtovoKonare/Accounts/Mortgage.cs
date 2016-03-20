using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Customers;

namespace _02BankOfKurtovoKonare.Accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, double interesRateInPercent, int month, decimal depositMoney = 0)
            : base(customer, balance, interesRateInPercent, month)
        {
            AddMoneyToBankStatus(depositMoney);
        }

        public override decimal CalculateInterest(int mounts)
        {
            if (customer is Individual)
            {
                if (mounts <= 6)
                {
                    mounts = 0;
                }
                else
                {
                    mounts -= 6;
                }

            }
            else if (customer is Company)
            {
                if (mounts <= 12)
                {
                    decimal interest = base.CalculateInterest(mounts);
                    balance = interest / 2;
                    return balance ;
                }
                else
                {
                    decimal interest = base.CalculateInterest(mounts - 12);
                    balance = interest / 2;
                    return balance;
                }
            }

            return base.CalculateInterest(mounts);


        }
    }
}

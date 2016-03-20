using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Customers;

namespace _02BankOfKurtovoKonare.Accounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, double interesRateInPercent, int month, decimal depositMoney = 0)
            : base(customer, balance, interesRateInPercent, month)
        {
            AddMoneyToBankStatus(depositMoney);
        }

        public override decimal CalculateInterest(int mounts)
        {
            if (customer is Individual)
            {
                if (mounts <= 3)
                {
                    mounts = 0;
                }
                else
                {
                    mounts -= 3;
                }

            }
            else if (customer is Company)
            {
                if (mounts <= 2)
                {
                    mounts = 0;
                }
                else
                {
                    mounts -= 2;
                }
            }

            return base.CalculateInterest(mounts);

            
        }
    }
}

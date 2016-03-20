using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare.Accounts
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, double interesRateInPercent, int month, decimal depositMoney = 0, decimal withdrawMoney = 0)
            : base(customer, balance, interesRateInPercent, month)
        {
            AddMoneyToBankStatus(depositMoney);
            RemoveMoneyFromBankStatus(withdrawMoney);
        }
        public override decimal CalculateInterest(int mounts)
        {
            if (Balance > 0 && Balance <1000)
            {
                mounts = 0;
            }
            return base.CalculateInterest(mounts);
        }
    }
}

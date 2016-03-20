using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        double InterstRate { get; set; }
        int Mounth { get; set; }
        void AddMoneyToBankStatus(decimal money);
        void RemoveMoneyFromBankStatus(decimal money);
        decimal CalculateInterest(int mounth);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Accounts;
using _02BankOfKurtovoKonare.Customers;

namespace _02BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            Account deposit = new Deposit(new Individual("Petur", "Petrov", "M25365"), 1000, 2, 4);
            deposit.RemoveMoneyFromBankStatus(1500);
            Console.WriteLine(deposit);

            Account loan = new Loan(new Individual("Ivan", "Ivanov", "M26987"), 100, 3.5, 6);
            Console.WriteLine(loan);

            Account mortgage = new Mortgage(new Company("TC Guard", "EOOD"), 10000, 5, 10);
            Console.WriteLine(mortgage);
        }
    }
}
 
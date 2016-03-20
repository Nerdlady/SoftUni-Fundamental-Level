using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Interfaces;

namespace _02BankOfKurtovoKonare
{
    public class Customer : ICustomer
    {
        private string customerName;

        public Customer(string customerName)
        {
            this.CustomerName = customerName;
        }
        public string CustomerName 
        {
            get { return this.customerName; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name cannot be empty");
                }
                this.customerName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Type : {0} , Name: {1}" , this.GetType().Name , this.CustomerName);
        }
    }

}

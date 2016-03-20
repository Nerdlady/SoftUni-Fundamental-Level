using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    public class Payment
    {
        private string productName;
        private decimal productPrice;

        public Payment(string productName, decimal productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        public decimal ProductPrice
        {
            get { return this.productPrice; }
            set
            {
                if (value < 0)
                {
                    throw  new ArgumentOutOfRangeException("Product price cannot be negative");
                }
                this.productPrice = value;
            }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public override string ToString()
        {
            StringBuilder paymentInfo = new StringBuilder();
            paymentInfo.AppendFormat("Product Name: {0}\n", this.ProductName);
            paymentInfo.AppendFormat("Product Price: {0}.lv\n", this.ProductPrice);

            return paymentInfo.ToString();
        }
    }
}

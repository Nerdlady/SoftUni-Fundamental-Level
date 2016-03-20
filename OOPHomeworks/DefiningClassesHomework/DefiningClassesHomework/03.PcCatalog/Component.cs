using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PcCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get {return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Component name can't be empty");
                }
                this.name = value;
            }
        }
        public string Details 
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (this.price < 0)
                {
                    throw new ArgumentOutOfRangeException("Component price can't be negative number");
                }
                this.price = value;
            }
        }
        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            
        }
        public Component(string name, decimal price, string details = null) : this(name, price)
        {
            this.Details = details;
        }

        public override string ToString()
        {
             string output = this.name + ", ";
             if (!String.IsNullOrEmpty(details))
             {
                 output += this.details + ", ";
             }
             output += this.price + "lv.";
             return output;
        }
    }
}

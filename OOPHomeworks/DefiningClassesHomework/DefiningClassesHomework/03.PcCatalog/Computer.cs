using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PcCatalog
{
    class Computer
    {
        private string name;
        private decimal totalPrice;
        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            this.Price = calPrice(components);
        }
        public string Name 
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty");
                }
                this.name= value;
            }
        }
        public decimal Price { get; set; }

        public decimal calPrice (List<Component> computers)
        {
             totalPrice = 0m;
            foreach (Component computer in computers)
            {
                totalPrice += computer.Price;
                
            }
            return totalPrice;
        }

        public List<Component> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Components are mandatory");
                }
                this.components = value;
            }
        }

     
         public void Print()
        {
            
            string output = "PC name:" + this.name + "\n";
            foreach (Component component in this.components)
            {
                output += component.ToString() + "\n";
            }
            output += "Total price: " + this.Price +"lv";
            Console.WriteLine(output);
        }
    }
}

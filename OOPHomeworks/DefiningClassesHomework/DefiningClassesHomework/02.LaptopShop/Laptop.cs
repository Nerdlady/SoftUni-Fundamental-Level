using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, Battery battery, string manufacturer = null, string processor = null, int ram = 0,
                      string graphicsCard = null, string hdd = null, string screen = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;

        }


        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Moden can't be empty");
                }
                this.model = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentNullException("Price can't be empty");
                }
                this.price = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (ram < 0)
                {
                    throw new ArgumentOutOfRangeException("Ram can't be negative");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }
        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public override string ToString()
        {
            string output = "Model: " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manufacturer))
            {
                output += "Manufacturer: " + this.manufacturer + "\n";
            }

            if (!String.IsNullOrEmpty(this.processor))
            {
                output += "Processor: " + this.processor + "\n";
            }

            if (this.ram > 0)
            {
                output += "RAM: " + this.ram + " GB\n";
            }

            if (!String.IsNullOrEmpty(this.graphicsCard))
            {
                output += "Graphics card: " + this.graphicsCard + "\n";
            }

            if (!String.IsNullOrEmpty(this.hdd))
            {
                output += "HDD: " + this.hdd + "\n";
            }

            if (!String.IsNullOrEmpty(this.screen))
            {
                output += "Screen: " + this.screen + "\n";
            }

            output += battery;

            output += "Price: " + this.price + " lv.";
            return output;

        }
    }
}

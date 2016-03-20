using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private string battery;
        private double batteryLife;

        public Battery(string battery , double batteryLife)
        {
            this.Batterys = battery;
            this.BatteryLife = batteryLife;
        }
        public string Batterys
        {
            get {return this.battery; }
            set { this.battery = value; } 
        }
        public double BatteryLife 
        {
            get { return this.batteryLife; }
            set 
            {
                if ( batteryLife < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery Life can't be negative");
                }
                this.batteryLife = value;
            }
        }
        public override string ToString()
        {
            string output = "";
            if(!String.IsNullOrEmpty(this.battery))
            {
                output += "Battery:" + this.battery + "\n";
            }
            if(this.batteryLife > 0)
            {
                output += "Battety Life:" + this.batteryLife + "\n";
            }
            return output;

        }
    }
}

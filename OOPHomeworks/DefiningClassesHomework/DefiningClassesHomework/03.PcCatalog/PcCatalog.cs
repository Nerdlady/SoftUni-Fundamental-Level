using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PcCatalog
{
    class PcCatalog
    {
        static void Main(string[] args)
        {
            Component hdd = new Component("HDD Seagate", 129m, "1TB");
            Component ram = new Component("Ram Corsair", 79m, "8GB");
            Component gpu = new Component("Video card", 134.99m, "Ati Radeon");
            Component motherboard = new Component("Desktop Motherboard", 112.30m, "Asus-P8H61-M LE/CSM R2.0");
            Component monitor = new Component("Monitor Dell-E2015HV", 222.04m, "19.8 inch");
            Component processor = new Component("Processor INTEL Core I7-4790k", 407.06m, "4.4Ghz");

            List<Component> components1 = new List<Component>()
            {
                hdd, ram, gpu, motherboard, monitor, processor
            };

            List<Component> components2 = new List<Component>()
            {
                hdd, gpu, motherboard, processor
            };

            List<Component> components3 = new List<Component>()
            {
                hdd, ram, gpu, processor,monitor
            };

            Computer pc1 = new Computer("Asus", components1);
            Computer pc2 = new Computer("Dell", components2);
            Computer pc3 = new Computer("Acer", components3);

            List<Computer> computers = new List<Computer>();

            computers.Add(pc1);
            computers.Add(pc2);
            computers.Add(pc3);

            List<Computer> sortedComputers = computers.OrderBy(computer => computer.Price).ToList();


            foreach (Computer sortedComputer in sortedComputers)
            {
                sortedComputer.Print();
                Console.WriteLine();
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    class CustomerMain
    {
        static void Main(string[] args)
        {

            var cm1 = new Customer("Pesho", "Atanosov", "Peshev", "8508156699", "Iztok", "+359895445566", "pesho@email.bg", new List<Payment>(), CustomerType.OneTime);

            var cm2 = new Customer("Pesho", "Atanosov", "Peshev", "8508156699", "Iztok", "+359895445566", "pesho@email.bg",new List<Payment>(),  CustomerType.Diamond);
      
            var cm3 = (Customer)cm2.Clone();

            cm3.AddPayment(
                new Payment("Car", 5444),
                new Payment("House", 99999));

           Console.WriteLine(cm3);
           Console.WriteLine(cm2);
            
            Console.WriteLine("Equal: {0}",cm1 == cm2);
            
            Console.WriteLine(cm2.CompareTo(cm1));
        }
    }
}

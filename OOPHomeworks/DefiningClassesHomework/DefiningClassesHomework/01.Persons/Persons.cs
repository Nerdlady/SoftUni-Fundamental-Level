using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            Person one = new Person("Ivan", 25, "ivan@email.com");
            Person two = new Person("Gosho", 18 );
            Person three = new Person("Pesho", 15);

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
        }
    }
}

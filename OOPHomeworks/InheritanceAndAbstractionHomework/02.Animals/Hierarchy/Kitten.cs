using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Hierarchy
{
    class Kitten : Cat
    {

        public Kitten(string name, int age, string gender = null )
            : base(name, age , gender = "Female")
        {
        }

         
    }
}

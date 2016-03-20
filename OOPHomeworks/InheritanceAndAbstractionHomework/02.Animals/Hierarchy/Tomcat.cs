using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals.Hierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender = null)
            : base(name,age, gender = "Male")
        {

        }
    }
}

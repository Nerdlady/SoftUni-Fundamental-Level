using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Shapes
    {
        static void Main()
        {
            Circle circle = new Circle(2.50);
            Rectangle rectangle = new Rectangle(5, 3);
            Rhombus rhombus = new Rhombus(6, 7);

            IShape[] shapes = new IShape[]
            {
                circle,
                rectangle,
                rhombus
            };

            foreach (var print in shapes)
            {
                Console.WriteLine(print);
            }
        }
    }
}

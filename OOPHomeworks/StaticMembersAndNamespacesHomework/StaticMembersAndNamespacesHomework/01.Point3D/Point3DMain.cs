using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Point3D
{
    class Point3DMain
    {
        public static void Main()
        {
            Point3D first = new Point3D(2, -6, 11);
            Point3D second = new Point3D(5, 2.8, 38);
            Point3D start = Point3D.Start;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(start);
        }
    }
}

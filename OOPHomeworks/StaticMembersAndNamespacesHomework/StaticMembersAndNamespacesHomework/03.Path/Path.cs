using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;
using _02.DistanceCalculator;

namespace _03.Path
{
    class Path
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(3, 4.66, 5.55);
            Point3D p3 = new Point3D(5.6, 4.3, 2.2);

            Path3D path = new Path3D(p1, p2, p3);
            Console.WriteLine("Save path:\n{0}", path);
            Storage.SaveFile(".../.../Save.txt", path);
            Path3D loadPath = Storage.LoadFile(".../.../Load.txt");
            Console.WriteLine("Load path:\n{0}", loadPath);
        }
    }
}

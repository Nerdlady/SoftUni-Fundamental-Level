using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;


namespace _02.DistanceCalculator
{
    public class DistanceCalculatorMain
    {
        public static void Main(string[] args)
        {
            Point3D pointOne = new Point3D(-7, -4, 3);
            Point3D pointTwo = new Point3D(17, 6, 2.5);
            Console.WriteLine("Distance between {0} and {1} is {2}", pointOne, pointTwo, DistanceCalculator.Calculate(pointOne, pointTwo));
            
        }
    }
}

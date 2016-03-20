using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;



namespace _02.DistanceCalculator
{

    public static class DistanceCalculator
    {

        public static double Calculate(Point3D first, Point3D second)
        {
            double distanceX = (second.X - first.X) * (second.X - first.X);
            double distanceY = (second.Y - first.Y) * (second.Y - first.Y);
            double distanceZ = (second.Z - first.Z) * (second.Z - first.Z);
            double finaldistance = Math.Sqrt(distanceX + distanceY + distanceZ);
            return finaldistance;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.DistanceCalculator;
using _01.Point3D;

namespace _03.Path
{
    public class Path3D
    {

        private List<Point3D> points = new List<Point3D>();

        public Path3D(params Point3D[] points)
        {
            if (points.Length > 0)
            {
                this.points.AddRange(points);
            }
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public override string ToString()
        {
            return string.Join("\n", this.points);
        }

    }

}

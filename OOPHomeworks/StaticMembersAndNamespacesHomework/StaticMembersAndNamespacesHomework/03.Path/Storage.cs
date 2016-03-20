using System;
using _01.Point3D;
using System.IO;
using System.Text.RegularExpressions;

namespace _03.Path
{
    public static class Storage
    {
        public static void SaveFile(string fileName, Path3D path)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(path);
            }

        }

        public static Path3D LoadFile(string fileName)
        {
            Path3D path = new Path3D();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string readFile = sr.ReadToEnd();

                string pattern = "(\\d+[\\.{1}\\d+]*).[^\\.\\d]*(\\d+[\\.{1}\\d+]*).[^\\.\\d]*(\\d+[\\.{1}\\d+]*)";
               
                var reg = new Regex(pattern);
                var matchs = reg.Matches(readFile);


                if (matchs.Count <= 0)
                {
                    throw new ApplicationException("Invalid data in file " + fileName);
                }

                foreach (Match match in matchs)
                {
                    double x = double.Parse(match.Groups[1].Value);
                    double y = double.Parse(match.Groups[2].Value);
                    double z = double.Parse(match.Groups[3].Value);

                    Point3D p = new Point3D(x, y, z);
                    path.AddPoint(p);
                }
            }

            return path;
        }

    }
}

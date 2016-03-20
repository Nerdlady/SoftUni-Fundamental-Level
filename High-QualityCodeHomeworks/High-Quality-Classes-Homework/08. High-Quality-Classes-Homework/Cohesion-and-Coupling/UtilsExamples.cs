namespace CohesionAndCoupling
{
    using System;

    internal class UtilsExamples
    {
        private static void Main()
        {
            Console.WriteLine(FileExtensions.GetFileExtension("example"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", DistanceCalculator.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", DistanceCalculator.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Cube.Width = 3;
            Cube.Height = 4;
            Cube.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Cube.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Cube.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Cube.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Cube.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Cube.CalculateDiagonalYZ());
        }
    }
}
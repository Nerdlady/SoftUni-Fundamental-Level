namespace Task3
{
    using System;

    using GameFifteen;

    public class WalkInMatrica
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var matrixSize = int.Parse(input);
            var matrix = new Matrix(matrixSize);
            Console.WriteLine(matrix);
        }
    }
}
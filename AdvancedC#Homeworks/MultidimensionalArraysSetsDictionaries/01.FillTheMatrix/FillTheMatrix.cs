namespace _01.FillTheMatrix
{
    using System;
    using System.Globalization;

    class FillTheMatrix
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int num = 1;
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[col, row] = num;
                    num++;
                }
            }

            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    Console.Write(matrix[row, col] + " ");

                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] secondMatrix = new int[size, size];

            num = 1;
            for (int col = 0; col < size; col++)
            {
                int rowIndex = size - 1;
                for (int row = 0; row < size; row++)
                {
                    if (col % 2 == 0)
                    {
                        secondMatrix[col, row] = num;
                    }
                    else
                    {
                        secondMatrix[col, rowIndex] = num;
                        rowIndex--;
                    }

                    num++;
                }
            }


            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    var m = secondMatrix[col, row];
                    Console.Write(secondMatrix[col, row] + " ");

                }
                Console.WriteLine();
            }


        }
    }
}

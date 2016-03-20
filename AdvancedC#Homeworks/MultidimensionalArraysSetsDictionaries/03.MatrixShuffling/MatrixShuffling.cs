namespace _03.MatrixShuffling
{
    using System;
    using System.Linq;

    class MatrixShuffling
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] stringsInRow = new string[cols];
                for (int col = 0; col < cols; col++)
                {
                    stringsInRow[col] = Console.ReadLine();
                }
                matrix[row] = stringsInRow;
            }


            string input = Console.ReadLine();

            while (input != "END")
            {
                var parameters = input.Split(' ').ToArray();

                switch (parameters[0])
                {
                    case "swap":
                        var isSwap = Swap(matrix, parameters, rows, cols);
                        if (isSwap)
                        {
                            for (int row = 0; row < rows; row++)
                            {
                                for (int col = 0; col < cols; col++)
                                {
                                    Console.Write(matrix[row][col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static bool Swap(string[][] matrix, string[] parameters, int rows, int cols)
        {
            int[] num = new int[4];


            for (int m = 0; m < num.Length; m++)
            {
                var numToParse = int.Parse(parameters[m + 1]);
                if (numToParse > matrix.Count())
                {
                    Console.WriteLine("Invalid input");
                    return false;
                }
                num[m] = numToParse;
            }

            string number = matrix[num[0]][num[1]];
            matrix[num[0]][num[1]] = matrix[num[2]][num[3]];
            matrix[num[2]][num[3]] = number;

            return true;

        }


    }
}

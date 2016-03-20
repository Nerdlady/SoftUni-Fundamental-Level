namespace _02.MaximalSum
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] { ',', ';', ' ' },
                         StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];
            int[][] matrix = new int[rows][];



            for (int index = 0; index < rows; index++)
            {
                int[] colSize = new int[cols];
                var lines = Console.ReadLine().Split(new char[] { ',', ';', ' ' },
                        StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int i = 0; i < cols; i++)
                {
                    colSize[i] = lines[i];
                }

                matrix[index] = colSize;

            }

            int maxSum = int.MinValue;
            int[,] matrixToPrint = new int[3,3];
            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    int currenRowSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2];
                    int nextRowSum = matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2];
                    int finalRowSum = matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    int currentSum = currenRowSum + nextRowSum + finalRowSum;

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        for (int printMatrixRow = 0; printMatrixRow < 3; printMatrixRow++)
                        {
                            for (int printMatrixCol = 0; printMatrixCol < 3; printMatrixCol++)
                            {
                                matrixToPrint[printMatrixRow, printMatrixCol] = matrix[row + printMatrixRow][col + printMatrixCol];
                            }
                        }
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (int printRow = 0; printRow < 3; printRow++)
            {
                for (int printCol = 0; printCol < 3; printCol++)
                {
                    Console.Write(matrixToPrint[printRow,printCol] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

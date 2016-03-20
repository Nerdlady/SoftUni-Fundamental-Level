namespace _04.SequenceInMatrix
{
    using System;
    using System.Linq;

    class SequenceInMatrix
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] stringsInRow = new string[cols];
                var lines = Console.ReadLine().Split(new char[] { ',', ';', ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    stringsInRow[col] = lines[col];
                }
                matrix[row] = stringsInRow;
            }

            int maxCount = 0;
            string maxString = string.Empty;
            int currentCount = 1;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row][col] != matrix[row][col + 1])
                    {
                        currentCount = 0;
                    }
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxString = matrix[row][col];
                    }
                }
            }

            currentCount = 1;
            for (int col = 0; col < cols - 1; col++)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (matrix[row][col] != matrix[row + 1][col])
                    {
                        currentCount = 0;
                    }
                    currentCount++;


                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxString = matrix[row][col];
                    }
                }
            }

            currentCount = 1;
            int startCol = 0;
            while (startCol < matrix[0].GetLength(0))
            {
                
                for (int row = 0, col = startCol; row < rows - 1 && col < cols - 1; row++, col++)
                {

                    if (matrix[row][col] != matrix[row + 1][col + 1])
                    {
                        currentCount = 0;
                    }
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxString = matrix[row][col];
                    }

                }
                startCol++;
            }


            string[] print = new string[maxCount];
            for (int index = 0; index < maxCount; index++)
            {
                print[index] = maxString;
            }
            Console.WriteLine(string.Join(", ", print));
        }
    }
}

namespace _05.CollectTheCoins
{
    using System;

    class CollectTheCoins
    {
        private static int coins = 0;

        private static int walls = 0;

        private static int rowPossition = 0;
        private static int colPossition = 0;

        static void Main()
        {
            const int marixSize = 4;
            char[][] matrix = new char[marixSize][];

            for (int row = 0; row < marixSize; row++)
            {
                string rowText = Console.ReadLine();
                char[] col = rowText.ToCharArray();

                matrix[row] = col;
            }

            string input = Console.ReadLine();
            char[] moves = input.ToCharArray();
            
            for (int index = 0; index < moves.Length; index++)
            {
                switch (moves[index])
                {
                    case 'V':
                        MoveDown(matrix);
                        break;
                    case '>':
                        MoveRight(matrix);
                        break;
                    case '^':
                        MoveUp(matrix);
                        break;
                    case '<':
                        MoveLeft(matrix);
                        break;
                }
            }

            Console.WriteLine("Coins collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", walls);

        }

        static void MoveDown(char[][] matrix)
        {
            if (rowPossition + 1 >= 4 || colPossition >= matrix[rowPossition + 1].Length)
            {
                walls++;
                return;
            }

            rowPossition++;
            char symbol = matrix[rowPossition][colPossition];
            if (symbol == '$')
            {
                coins++;
            }
            
        }

        static void MoveRight(char[][] matrix)
        {
            if (colPossition + 1 >= matrix[rowPossition].Length)
            {
                walls++;
                return;
            }

            colPossition++;
            char symbol = matrix[rowPossition][colPossition];
            if (symbol == '$')
            {
                coins++;
            }

        }

        static void MoveUp(char[][] matrix)
        {
            if (rowPossition - 1 == -1 || colPossition >= matrix[rowPossition - 1].Length)
            {
                walls++;
                return;
            }

            rowPossition--;
            char symbol = matrix[rowPossition][colPossition];
            if (symbol == '$')
            {
                coins++;
            }

        }

        static void MoveLeft(char[][] matrix)
        {
            if (colPossition - 1 == -1)
            {
                walls++;
                return;
            }

            colPossition--;
            char symbol = matrix[rowPossition][colPossition];
            if (symbol == '$')
            {
                coins++;
            }

        }
    }
}

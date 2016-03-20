namespace _02.SortArrayOfNumbersWithSelectionSort
{
    using System;

    class SortArrayOfNumbersWithSelectionSort
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(input, int.Parse);

            for (int currentNumIndex = 0; currentNumIndex < numbers.Length - 1; currentNumIndex++)
            {
                int minNumIndex = currentNumIndex;
                for (int nextNumIndex = currentNumIndex +1; nextNumIndex < numbers.Length; nextNumIndex++)
                {
                    int minNumber = numbers[minNumIndex];
                    int nextNumber = numbers[nextNumIndex];
                    if (minNumber > nextNumber)
                    {
                        minNumIndex = nextNumIndex;
                    }
                }

                int number = numbers[currentNumIndex];
                numbers[currentNumIndex] = numbers[minNumIndex];
                numbers[minNumIndex] = number;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

namespace _03.LargerThanNeighbours
{
    using System;
    using System.Linq;

    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            int[] secondNumbers = { 1, 2, 3, 4, 5, 6, 6 };
            int[] thirtNumber = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(numbers));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(secondNumbers));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(thirtNumber));


        }

        static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                if (index == 0)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        return index;
                    }
                }
                else if (index == numbers.Length - 1)
                {
                    if (numbers[index] > numbers[index - 1])
                    {
                        return index;
                    }
                }
                else if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
                {
                    return index;
                }
            }


            return -1;
        }
    }
}

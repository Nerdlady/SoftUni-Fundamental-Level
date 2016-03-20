namespace _03.LargerThanNeighbours
{
    using System;
    using System.Linq;

    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = {1,3,4,5,1,0,5};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
                
            }
        }

        static bool IsLargerThanNeighbours(int[] numbers, int index)
        {
            if (index == 0)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    return true;
                }
            }
            else if (index == numbers.Length - 1)
            {
                if (numbers[index] > numbers[index - 1])
                {
                    return true;
                }
            }
            else if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index+1])
            {
                return true;
            }

            return false;
        }
    }
}

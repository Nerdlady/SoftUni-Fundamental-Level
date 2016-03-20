namespace _05.LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSequence
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> output = new List<int>();
            List<int> longestSequence = new List<int>();

            while (numbers.Count > 0)
            {
                output.Add(numbers[0]);
                numbers.Remove(numbers[0]);

                for (int index = 0; index < numbers.Count; index++)
                {
                    if (numbers[index] > output[output.Count - 1])
                    {
                        output.Add(numbers[index]);
                        numbers.Remove(numbers[index]);
                        index--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (longestSequence.Count < output.Count)
                {
                    longestSequence.Clear();
                    longestSequence.InsertRange(0, output);
                }

                Console.WriteLine(string.Join(" ", output));
                output.Clear();
            }

            Console.WriteLine("Longest: " + string.Join(" ", longestSequence));
        }
    }
}

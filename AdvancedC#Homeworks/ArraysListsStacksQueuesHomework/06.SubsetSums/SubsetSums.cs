namespace _06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSums
    {
        static void Main()
        {
            int wantedSum = int.Parse(Console.ReadLine());

            var numbers = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
          
            bool found = false;

            int numOfSubsets = 1 << numbers.Count;

            for (int i = 0; i < numOfSubsets; i++)
            {
                List<int> subset = new List<int>();

                int possition = numbers.Count - 1;
                int bitmask = i;

                while (bitmask > 0)
                {
                    if ((bitmask & 1) == 1)
                    {
                        subset.Add(numbers.ElementAt(possition));
                    }

                    bitmask >>= 1;
                    possition--;
                }
                if ((subset.Sum() == wantedSum) && (subset.Count != 0))
                {
                    found = true;
                    Console.WriteLine(string.Join(" + ", subset) + " = {0}", wantedSum);
                }
            }
            if (!found)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}

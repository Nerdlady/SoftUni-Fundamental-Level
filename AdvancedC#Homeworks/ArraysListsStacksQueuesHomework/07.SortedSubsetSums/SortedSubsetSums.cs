namespace _07.SortedSubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedSubsetSums
    {
        static void Main()
        {
            int wantedSum = int.Parse(Console.ReadLine());

            var numbers = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

            IList<IList<int>> unsorted = new List<IList<int>>();

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
                        subset.Add(numbers.ElementAt<int>(possition));
                    }
                    bitmask >>= 1;
                    possition--;
                }
                if ((subset.Sum() == wantedSum) && (subset.Count != 0))
                {
                    found = true;
                    subset.Sort();
                    unsorted.Add(subset);

                }
            }

            IList<IList<int>> sorted = unsorted.OrderBy(x => x.Count).ThenBy(x => x.ElementAt(0)).ToList();

            if (found)
            {
                foreach (IList<int> list in sorted)
                {
                    Console.WriteLine(string.Join(" + ", list) + " = " + wantedSum);
                }
            }
            else
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}

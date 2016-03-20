namespace _06CountSymbols
{
    using System;
    using System.Collections.Generic;

    class CountSymbols
    {
        static void Main()
        {
            string intput = Console.ReadLine();

            SortedDictionary<char, int> results = new SortedDictionary<char, int>();

            foreach (char character in intput)
            {
                if (results.ContainsKey(character))
                {
                    results[character]++;
                }
                else
                {
                    results.Add(character, 1);
                }
            }

            foreach (var result in results)
            {
                Console.WriteLine("{0}: {1} time/s" , result.Key,result.Value);
            }
            
        }
    }
}

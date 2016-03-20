namespace _06.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Palindromes
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new []{' ','!',',','?','.'} , StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();

            foreach (var word in input)
            {
                string reversed = new string(word.Reverse().ToArray());
                if (word == reversed)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}

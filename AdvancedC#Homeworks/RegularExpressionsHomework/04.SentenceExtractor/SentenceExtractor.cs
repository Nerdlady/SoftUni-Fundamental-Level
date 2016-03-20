namespace _04.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    class SentenceExtractor
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b(.)*?( " + keyword + " )(.)*?[!|?|.]");

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}

namespace _06.ExtractHyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ExtractHyperlinks
    {
        static void Main()
        {
            Regex regex = new Regex(@"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>");

            StringBuilder input = new StringBuilder();
            string line = Console.ReadLine();

            while (line != "END")
            {
                input.Append(line);
                line = Console.ReadLine();
            }

            string text = input.ToString();


            Match match = regex.Match(text);
            while (match != Match.Empty)
            {
                for (int index = 1; index < match.Groups.Count; index++)
                {
                    if (match.Groups[index].Value != string.Empty)
                    {
                        Console.WriteLine(match.Groups[index].Value);
                    }
                }

                match = match.NextMatch();
            }

        }

    }
}

namespace _03.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([a-z][\w.-]*?[a-z])@(\w*?\.\w+)+");

            var matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}

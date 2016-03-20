namespace _02.ReplaceTag
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceTag
    {
        static void Main()
        {
            string input = File.ReadAllText(@"..\..\input.txt");

            Regex regex = new Regex(@"(<a )(href=).(.*?(?=)).>(.*?(?=<))(<\/a>)");
            input = regex.Replace(input, "[URL $2$3]$4[/URL]");
            Console.WriteLine(input);

        }
    }
}

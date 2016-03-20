namespace _01.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    class SeriesOfLetters
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"(\w)\1+");
            Console.WriteLine(regex.Replace(text, "$1"));
        }
    }
}

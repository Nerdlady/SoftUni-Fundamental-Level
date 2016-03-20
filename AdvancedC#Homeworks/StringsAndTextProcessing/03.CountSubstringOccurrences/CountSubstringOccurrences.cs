
namespace _03.CountSubstringOccurrences
{
    using System;
    using System.Linq;

    class CountSubstringOccurrences
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string subString = Console.ReadLine();

            int count = text.Select((c, i) => text.Substring(i)).Count(x => x.StartsWith(subString, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);
        }
    }
}

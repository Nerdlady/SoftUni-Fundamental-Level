namespace _04.TextFilter
{
    using System;
    using System.Linq;

    class TextFilter
    {
        static void Main()
        {
            var filter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            text = filter.Aggregate(text, (current, word) => current.Replace(word, new string('*', word.Length)));

            Console.WriteLine(text);
        }
    }
}

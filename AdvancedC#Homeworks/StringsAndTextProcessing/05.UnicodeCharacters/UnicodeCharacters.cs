namespace _05.UnicodeCharacters
{
    using System;

    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }
            Console.WriteLine();
        }
    }
}

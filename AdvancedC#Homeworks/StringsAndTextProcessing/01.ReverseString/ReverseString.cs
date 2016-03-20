namespace _01.ReverseString
{
    using System;
    using System.Linq;

    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine(reversed);
        }
    }
}

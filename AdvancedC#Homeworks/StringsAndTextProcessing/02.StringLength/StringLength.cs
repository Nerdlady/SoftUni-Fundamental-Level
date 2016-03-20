namespace _02.StringLength
{
    using System;
    using System.Linq;

    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputToChars = input.ToCharArray();
            char[] output = new char[20];

            for (int index = 0; index < output.Length; index++)
            {
                if (index < inputToChars.Length)
                {
                    output[index] = inputToChars[index];
                }
                else
                {
                    output[index] = '*';
                }
            }

            string print = new string(output.ToArray());

            Console.WriteLine(print);
        }
    }
}

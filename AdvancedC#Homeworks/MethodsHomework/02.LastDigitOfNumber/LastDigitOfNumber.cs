namespace _02.LastDigitOfNumber
{
    using System;
    using System.Linq;

    class LastDigitOfNumber
    {
        static void Main()
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }

        static string GetLastDigitAsWord(int number)
        {
            string numToString = number.ToString();
            char[] numbers = numToString.ToCharArray();

            int lastNumber = numbers.Last();

            switch (lastNumber)
            {
                case '0':
                    return "zero";
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
            }
            return string.Empty;
        }
    }
}

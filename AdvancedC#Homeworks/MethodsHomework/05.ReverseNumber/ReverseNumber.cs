namespace _05.ReverseNumber
{
    using System;

    class ReverseNumber
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReverseNumber(number));
        }

        static double GetReverseNumber(double number)
        {
            var numberToString = number.ToString();
            char[] numberInCharArray = numberToString.ToCharArray();
            Array.Reverse(numberInCharArray);
            string output = string.Empty;
            for (int index = 0; index < numberInCharArray.Length; index++)
            {
                output += numberInCharArray[index];
            }
                                
            return double.Parse(output);

        }
    }
}

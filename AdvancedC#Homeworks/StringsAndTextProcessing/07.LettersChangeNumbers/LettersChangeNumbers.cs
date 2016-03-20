namespace _07.LettersChangeNumbers
{
    using System;
    using System.Linq;

    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;
            foreach (var combination in input)
            {
                 char left = combination.First();
                char right = combination.Last();
                double number = double.Parse(combination.Substring(1, combination.Length - 2));

                number = ApplyFirstLetterCalculations(left, number);

                number = ApplySecondLetterCalculations(right, number);

                result += number;
            }

            Console.WriteLine("{0:F2}",result);
        }

        private static double ApplySecondLetterCalculations(char lastLetter, double number)
        {
            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 'A' + 1;
            }
            else if (char.IsLower(lastLetter))
            {
                number += lastLetter - 'a' + 1;
            }
            return number;
        }

        private static double ApplyFirstLetterCalculations(char firstLetter, double number)
        {
            if (char.IsUpper(firstLetter))
            {
                number /= firstLetter - 'A' + 1;
            }
            else if (char.IsLower(firstLetter))
            {
                number *= firstLetter - 'a' + 1;
            }
            return number;
        }
    }
}

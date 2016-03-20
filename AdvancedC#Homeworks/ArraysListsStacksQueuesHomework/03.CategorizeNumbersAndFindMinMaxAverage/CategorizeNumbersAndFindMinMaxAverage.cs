namespace _03.CategorizeNumbersAndFindMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategorizeNumbersAndFindMinMaxAverage
    {
        static void Main()
        {
            const string outputFormat = "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}";
            string[] input = Console.ReadLine().Split(' ');
            IList<double> doubleNumbers = new List<double>();
            IList<int> intNumbers = new List<int>();

            for (int index = 0; index < input.Length; index++)
            {
                if (input[index].Contains("."))
                {
                    double parsedNum = double.Parse(input[index]);
                    int parsedNumAsInt = (int)parsedNum;
                    if (!(parsedNum - parsedNumAsInt == 0))
                    {
                        doubleNumbers.Add(parsedNum);
                    }
                    else
                    {
                        intNumbers.Add(parsedNumAsInt);
                    }
                }
                else
                {
                    int parsedNum = int.Parse(input[index]);
                    intNumbers.Add(parsedNum);
                }
            }

            double minDouble = doubleNumbers.Min();
            double maxDoube = doubleNumbers.Max();
            double doubleSum = doubleNumbers.Sum();
            double doubleAvg = doubleNumbers.Average();

            int minInt = intNumbers.Min();
            int maxInt = intNumbers.Max();
            int intSum = intNumbers.Sum();
            double intAvg = intNumbers.Average();


            Console.WriteLine(outputFormat, string.Join(", " , doubleNumbers), minDouble,maxDoube,doubleSum,doubleAvg);
            Console.WriteLine(outputFormat, string.Join(", ", intNumbers), minInt, maxInt, intSum, intAvg);
        }
    }
}

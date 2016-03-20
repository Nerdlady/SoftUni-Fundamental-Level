namespace _06.NumberCalculations
{
    using System;
    using System.Linq;
    using System.Text;

    class NumberCalculations
    {
        static void Main(string[] args)
        {
            char[] charSeparators = new char[] { ' ' };

            Console.WriteLine("Enter double numbers");
            double[] doubles = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            DoubleCalculations doubleCalculations = new DoubleCalculations(doubles);

            StringBuilder doubleOutput = new StringBuilder();
            doubleOutput.AppendLine("Min: " + doubleCalculations.GetMin())
                .AppendLine("Max: " + doubleCalculations.GetMax())
                .AppendLine("Sum: " + doubleCalculations.GetSum())
                .AppendLine("Average: " + doubleCalculations.GetAverage())
                .AppendLine("Product: " + doubleCalculations.GetProduct());

            Console.WriteLine(doubleOutput.ToString());

            Console.WriteLine("Enter decimal numbers");
            decimal[] decimals = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            DecimalCalculations decimalCalculations = new DecimalCalculations(decimals);


            StringBuilder decimalOutput = new StringBuilder();
            decimalOutput.AppendLine("Min: " + decimalCalculations.GetMin())
                .AppendLine("Max: " + decimalCalculations.GetMax())
                .AppendLine("Sum: " + decimalCalculations.GetSum())
                .AppendLine("Average: " + decimalCalculations.GetAverage())
                .AppendLine("Product: " + decimalCalculations.GetProduct());

            Console.WriteLine(decimalOutput.ToString());
        }
    }
}

namespace Methods
{
    using System;

    internal class MethodsMain
    {
        private static void Main()
        {
            Console.WriteLine(Calculations.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Formatting.PrintDigitAsWord(5));

            Console.WriteLine(Calculations.FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(Formatting.FormatNmber(1.3, "f"));
            Console.WriteLine(Formatting.FormatNmber(0.75, "%"));
            Console.WriteLine(Formatting.FormatNmber(2.30, "r"));
            
            Console.WriteLine(Calculations.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Calculations.IsHorizontalLine(3, 3));
            Console.WriteLine("Vertical? " + Calculations.IsVerticalLine(-1, 2.5));

            Student peter = new Student { FirstName = "Peter", LastName = "Ivanov" };
            peter.Info = "From Sofia, born at 17.03.1992";

            Student stella = new Student { FirstName = "Stella", LastName = "Markova" };
            stella.Info = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PerformanceOfoperationsPartTwo
{
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("+-----------+------------------+------------------+------------------+");
            Console.WriteLine("| n=1000000 |     SquareRoot   |         Log      |        Sine      |");
            Console.WriteLine("+-----------+------------------+------------------+------------------+");

            FloatValues(stopwatch);
            DoubleValues(stopwatch);
            DecimalValues(stopwatch);
            Console.WriteLine("+-----------+------------------+------------------+------------------+");
        }

        private static void DecimalValues(Stopwatch stopwatch)
        {
            // Test square root decimal values
            stopwatch.Start();
            Methods.PerformSquareRootOnDecimalValue();
            stopwatch.Stop();
            Console.Write("| Decimal:  | " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test natural logarithm decimal values
            stopwatch.Start();
            Methods.PerformNaturalLogarithmOnDecimalValue();
            stopwatch.Stop();
            Console.Write(" | " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test sine  decimal values
            stopwatch.Start();
            Methods.PerformSineOnDecimalValue();
            stopwatch.Stop();
            Console.WriteLine(" | " + stopwatch.Elapsed + " |");

            stopwatch.Reset();
        }

        private static void FloatValues(Stopwatch stopwatch)
        {
            // Test square root float values
            stopwatch.Start();
            Methods.PerformSquareRootOnFloatValue();
            stopwatch.Stop();
            Console.Write("| Float:    | " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test natural logarithm float values
            stopwatch.Start();
            Methods.PerformNaturalLogarithmOnFloatValue();
            stopwatch.Stop();
            Console.Write(" | " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test sine  float values
            stopwatch.Start();
            Methods.PerformSineOnFloatValue();
            stopwatch.Stop();
            Console.WriteLine(" | " + stopwatch.Elapsed + " |");

            stopwatch.Reset();
        }


        private static void DoubleValues(Stopwatch stopwatch)
        {
            // Test square root double values
            stopwatch.Start();
            Methods.PerformSquareRootOnDoubleValue();
            stopwatch.Stop();
            Console.Write("| Double:   | " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test natural logarithm double values
            stopwatch.Start();
            Methods.PerformNaturalLogarithmOnDoubleValue();
            stopwatch.Stop();
            Console.Write(" | " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test sine  double values
            stopwatch.Start();
            Methods.PerformSineOnDoubleValue();
            stopwatch.Stop();
            Console.WriteLine(" | " + stopwatch.Elapsed + " |");

            stopwatch.Reset();
        }
    }
}

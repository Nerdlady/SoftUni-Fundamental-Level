namespace _01.PerformanceOfOperations
{
    using System;
    using System.Diagnostics;

    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            
            IntegerValues(stopwatch);

            LongValues(stopwatch);

            FloatValues(stopwatch);

            DoubleValues(stopwatch);

            DecimalValues(stopwatch);
        }

        private static void DecimalValues(Stopwatch stopwatch)
        {
            // Test adding decimal values
            stopwatch.Start();
            Methods.AddDecimalValues();
            stopwatch.Stop();
            Console.Write("Decimal: " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test subtracting decimal values
            stopwatch.Start();
            Methods.SubtractDecimalValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test incrementing decimal values
            stopwatch.Start();
            Methods.IncrementDecimalValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            //Test plus equel decimal value
            stopwatch.Start();
            Methods.PlusEqualDecimalValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();;

            // Test multiplying decimal values
            stopwatch.Start();
            Methods.MultiplyDecimalValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test dividing decimal values
            stopwatch.Start();
            Methods.DivideDecimalValues();
            stopwatch.Stop();
            Console.WriteLine("    " + stopwatch.Elapsed);

            stopwatch.Reset();
        }

        private static void DoubleValues(Stopwatch stopwatch)
        {
            // Test adding double values
            stopwatch.Start();
            Methods.AddDoubleValues();
            stopwatch.Stop();
            Console.Write("Double: " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test subtracting double values
            stopwatch.Start();
            Methods.SubtractDoubleValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test incrementing double values
            stopwatch.Start();
            Methods.IncrementDoubleValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            //Test plus equel double value
            stopwatch.Start();
            Methods.PlusEqualDoubleValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset(); ;

            // Test multiplying double values
            stopwatch.Start();
            Methods.MultiplyDoubleValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test dividing double values
            stopwatch.Start();
            Methods.DivideDoubleValues();
            stopwatch.Stop();
            Console.WriteLine("    " + stopwatch.Elapsed);

            stopwatch.Reset();
        }

        private static void FloatValues(Stopwatch stopwatch)
        {
            // Test adding float values
            stopwatch.Start();
            Methods.AddFloatValues();
            stopwatch.Stop();
            Console.Write("Float: " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test subtracting float values
            stopwatch.Start();
            Methods.SubtractFloatValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test incrementing float values
            stopwatch.Start();
            Methods.IncrementFloatValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            //Test plus equel float value
            stopwatch.Start();
            Methods.PlusEqualFloatValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset(); ;

            // Test multiplying float values
            stopwatch.Start();
            Methods.MultiplyFloatValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test dividing float values
            stopwatch.Start();
            Methods.DivideFloatValues();
            stopwatch.Stop();
            Console.WriteLine("    " + stopwatch.Elapsed);

            stopwatch.Reset();
        }

        private static void LongValues(Stopwatch stopwatch)
        {
            // Test adding long values
            stopwatch.Start();
            Methods.AddLongValues();
            stopwatch.Stop();
            Console.Write("Long: " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test subtracting long values
            stopwatch.Start();
            Methods.SubtractLongValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test incrementing long values
            stopwatch.Start();
            Methods.IncrementLongValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            //Test plus equel long value
            stopwatch.Start();
            Methods.PlusEqualLongValue();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset(); ;

            // Test multiplying long values
            stopwatch.Start();
            Methods.MultiplyLongValues();
            stopwatch.Stop();
            Console.Write("    " + stopwatch.Elapsed);

            stopwatch.Reset();

            // Test dividing long values
            stopwatch.Start();
            Methods.DivideLongValues();
            stopwatch.Stop();
            Console.WriteLine("    " + stopwatch.Elapsed);

            stopwatch.Reset();
        }

        private static void IntegerValues(Stopwatch stopwatch)
        {
            // Test adding int values
            stopwatch.Start();
            Methods.AddIntValues();
            stopwatch.Stop();
            Console.Write("Int: {0}", stopwatch.Elapsed);

            stopwatch.Reset();

            // Test subtracting int values
            stopwatch.Start();
            Methods.SubtractIntValues();
            stopwatch.Stop();
            Console.Write("    {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            // Test incrementing int values
            stopwatch.Start();
            Methods.IncrementIntValue();
            stopwatch.Stop();
            Console.Write("    {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            //Test plus equel int value
            stopwatch.Start();
            Methods.PlusEqualIntValue();
            stopwatch.Stop();
            Console.Write("    {0,10}", stopwatch.Elapsed);

            stopwatch.Reset(); ;

            // Test multiplying int values
            stopwatch.Start();
            Methods.MultiplyIntValues();
            stopwatch.Stop();
            Console.Write("    {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();

            // Test dividing int values
            stopwatch.Start();
            Methods.DivideIntValues();
            stopwatch.Stop();
            Console.WriteLine("    {0,10}", stopwatch.Elapsed);

            stopwatch.Reset();
        }
    }
}
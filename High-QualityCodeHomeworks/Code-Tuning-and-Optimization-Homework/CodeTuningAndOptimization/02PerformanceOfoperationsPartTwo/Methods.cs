using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PerformanceOfoperationsPartTwo
{
    public class Methods
    {
        private const int NumberOfOperationsToPerform = 1000000;

        private const float FloatValue = 1.1f;
        private const double DoubleValue = 1.1;
        private const decimal DecimalValue = 1.1m;

        public static void PerformSquareRootOnFloatValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Sqrt(FloatValue);
            }
        }

        public static void PerformSquareRootOnDoubleValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Sqrt(DoubleValue);
            }
        }

        public static void PerformSquareRootOnDecimalValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Sqrt((double)DecimalValue);
            }
        }

        public static void PerformNaturalLogarithmOnFloatValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Log(FloatValue, Math.E);
            }
        }

        public static void PerformNaturalLogarithmOnDoubleValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Log(DoubleValue, Math.E);
            }
        }

        public static void PerformNaturalLogarithmOnDecimalValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Log((double)DecimalValue, Math.E);
            }
        }

        public static void PerformSineOnFloatValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Sin(FloatValue);
            }
        }

        public static void PerformSineOnDoubleValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Sin(DoubleValue);
            }
        }

        public static void PerformSineOnDecimalValue()
        {
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                Math.Sin((double)DecimalValue);
            }
        }
    }
}

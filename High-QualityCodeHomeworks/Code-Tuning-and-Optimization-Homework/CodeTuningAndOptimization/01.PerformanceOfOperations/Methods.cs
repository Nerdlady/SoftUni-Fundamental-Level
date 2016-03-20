using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PerformanceOfOperations
{
    public class Methods
    {
        private const int NumberOfOperationsToPerform = 1000000;

        private const int FirstIntNumber = 1;
        private const int SecondIntNumber = 5;

        private const long FirstLongNumber = 1L;
        private const long SecondLongNumber = 10000000L;

        private const float FirstFloatNumber = 1.1f;
        private const float SecondFloatNumber = 3.14f;

        private const double FirstDoubleNumber = 1.1;
        private const double SecondDoubleNumber = 3.14;

        private const decimal FirstDecimalNumber = 1.1m;
        private const decimal SecondDecimalNumber = 3.14m;

        public static void AddIntValues()
        {
            int result;

            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstIntNumber + SecondIntNumber;
            }
        }

        public static void AddLongValues()
        {
            long result;

            for (long i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstLongNumber + SecondLongNumber;
            }
        }

        public static void AddFloatValues()
        {
            float result;

            for (float i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstFloatNumber + SecondFloatNumber;
            }
        }

        public static void AddDoubleValues()
        {
            double result;

            for (double i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDoubleNumber + SecondDoubleNumber;
            }
        }

        public static void AddDecimalValues()
        {
            decimal result;

            for (decimal i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDecimalNumber + SecondDecimalNumber;
            }
        }

        public static void SubtractIntValues()
        {
            int result;

            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstIntNumber - SecondIntNumber;
            }
        }

        public static void SubtractLongValues()
        {
            long result;

            for (long i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstLongNumber - SecondLongNumber;
            }
        }

        public static void SubtractFloatValues()
        {
            float result;

            for (float i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstFloatNumber - SecondFloatNumber;
            }
        }

        public static void SubtractDoubleValues()
        {
            double result;

            for (double i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDoubleNumber - SecondDoubleNumber;
            }
        }

        public static void SubtractDecimalValues()
        {
            decimal result;

            for (decimal i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDecimalNumber - SecondDecimalNumber;
            }
        }

        public static void IncrementIntValue()
        {
            int result = 0;

            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result++;
            }
        }

        public static void IncrementLongValue()
        {
            long result = 0L;

            for (long i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result++;
            }
        }

        public static void IncrementFloatValue()
        {
            float result = 0.1f;

            for (float i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result++;
            }
        }

        public static void IncrementDoubleValue()
        {
            double result = 0.1;

            for (double i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result++;
            }
        }

        public static void IncrementDecimalValue()
        {
            decimal result = 0.1m;

            for (decimal i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result++;
            }
        }

        public static void MultiplyIntValues()
        {
            int result;

            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstIntNumber * SecondIntNumber;
            }
        }

        public static void MultiplyLongValues()
        {
            long result;

            for (long i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstLongNumber * SecondLongNumber;
            }
        }

        public static void MultiplyFloatValues()
        {
            float result;

            for (float i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstFloatNumber * SecondFloatNumber;
            }
        }

        public static void MultiplyDoubleValues()
        {
            double result;

            for (double i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDoubleNumber * SecondDoubleNumber;
            }
        }

        public static void MultiplyDecimalValues()
        {
            decimal result;

            for (decimal i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDecimalNumber * SecondDecimalNumber;
            }
        }

        public static void DivideIntValues()
        {
            int result;

            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstIntNumber / SecondIntNumber;
            }
        }

        public static void DivideLongValues()
        {
            long result;

            for (long i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstLongNumber / SecondLongNumber;
            }
        }

        public static void DivideFloatValues()
        {
            float result;

            for (float i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstFloatNumber / SecondFloatNumber;
            }
        }

        public static void DivideDoubleValues()
        {
            double result;

            for (double i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDoubleNumber / SecondDoubleNumber;
            }
        }

        public static void DivideDecimalValues()
        {
            decimal result;

            for (decimal i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result = FirstDecimalNumber / SecondDecimalNumber;
            }
        }

        public static void PlusEqualIntValue()
        {
            int result = 0;
            for (int i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result += FirstIntNumber;
            }
        }

        public static void PlusEqualLongValue()
        {
            long result = 0;
            for (long i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result += FirstLongNumber;
            }
        }

        public static void PlusEqualFloatValue()
        {
            float result = 0;
            for (float i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result += FirstFloatNumber;
            }
        }

        public static void PlusEqualDoubleValue()
        {
            double result = 0;
            for (double i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result += FirstDoubleNumber;
            }
        }

        public static void PlusEqualDecimalValue()
        {
            decimal result = 0;
            for (decimal i = 0; i < NumberOfOperationsToPerform; i++)
            {
                result += FirstDecimalNumber;
            }
        }
    }
}

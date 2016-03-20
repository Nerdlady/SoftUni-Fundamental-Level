namespace _07.GenericArraySort
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class GenericArraySort
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            string[] strings = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates =
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
        };

            // printing
            Console.WriteLine(SortArray(numbers));
            Console.WriteLine(SortArray(strings));
            Console.WriteLine(SortArray(dates));
        }

        static string SortArray<T>(IEnumerable<T> array)
        {
            List<T> firstList = array.ToList();
            List<T> sorted = new List<T>();

            while (firstList.Count != 0)
            {
                var min = firstList.Min();
                sorted.Add(min);
                firstList.Remove(min);
            }
            return PrintArray(sorted);
        }

        private static string PrintArray<T>(IEnumerable<T> array)
        {
            return string.Join(", ", array);
        }
    }
}

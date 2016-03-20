namespace _01.SortArrayOfNumbers
{
    using System;

    public class SortArrayOfNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(input, int.Parse);
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

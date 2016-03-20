namespace _04.SequencesOfEqualStrings
{
    using System;
    using System.Linq;

    public class SequencesOfEqualStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            var groups = input.GroupBy(name => name);
            foreach (var group in groups)
            {
                Console.WriteLine(string.Join(" ", group));
            }
        }
    }
}

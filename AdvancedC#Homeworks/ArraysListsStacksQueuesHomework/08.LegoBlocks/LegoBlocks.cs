namespace _08.LegoBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LegoBlocks
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            IList<IList<int>> firstJaggedArray = new List<IList<int>>();

            IList<IList<int>> secondJaggedArray = new List<IList<int>>();

            int sum = 0;

            for (int index = 0; index < rows * 2; index++)
            {
                List<int> numbers = Console.ReadLine().Split(new char[] { ',', ';', ' ' },
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                if (index < rows)
                {
                    firstJaggedArray.Add(numbers);
                    sum += numbers.Count;
                }
                else
                {
                    numbers.Reverse();
                    secondJaggedArray.Add(numbers);
                    sum += numbers.Count;
                }
            }

            var colCount = firstJaggedArray[0].Count + secondJaggedArray[0].Count;

            bool isSame = false;
            for (int index = 1; index < rows; index++)
            {
                var nextColCount = firstJaggedArray[index].Count + secondJaggedArray[index].Count;
                if (colCount == nextColCount)
                {
                    isSame = true;
                }
                else
                {
                    isSame = false;
                }
            }

            List<string> secondResults = new List<string>();

            if (isSame)
            {
                for (int index = 0; index < rows; index++)
                {
                    string secondResult = string.Join(", ", secondJaggedArray[index]);
                    secondResults.Add(secondResult);
                    var m = string.Join(", ", firstJaggedArray[index]);
                    Console.WriteLine("[{0}]", m + ", " + secondResults[index]);
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}", sum);
                
            }
        }
    }
}

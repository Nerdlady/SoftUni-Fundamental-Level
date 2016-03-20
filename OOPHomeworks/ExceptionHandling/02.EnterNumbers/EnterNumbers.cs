using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int number = ReadNumber(start, end);
                start = number;
                numbers.Add(number);
            }

            Console.Write("Your numbers: ");
            foreach (int nums in numbers)
            {
                if (numbers.Max() != nums)
                {
                    Console.Write(nums + ", ");
                }
                
                else 
                {
                    Console.WriteLine(nums);
                }
            }
        }

        public static int ReadNumber(int start, int end)
        {
            int num = 0;

            try
            {
                Console.Write("Enter a number in range {0} - {1}: ", start, end);
                num = int.Parse(Console.ReadLine());

                if (num < start || num > end)
                {

                    Console.WriteLine("You can't enter number out of the range");
                    return ReadNumber(start, end);
                }

            }
            catch (ArgumentNullException e)
            {

                throw new ArgumentNullException(e.Message);
            }
            catch (FormatException e)
            {
                throw new FormatException(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException(e.Message);
            }
            return num;
        }
    }

}

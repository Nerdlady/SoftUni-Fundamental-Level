using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter possitive integer number");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Number should be possitive");
                }
                else
                {
                    Console.WriteLine("Square root of {0} is {1:F2}", num, Math.Sqrt(num));

                }
            }
            catch (ArgumentOutOfRangeException)
            {

                throw new ArgumentOutOfRangeException("Invalid number");
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid format");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Number is too big");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}

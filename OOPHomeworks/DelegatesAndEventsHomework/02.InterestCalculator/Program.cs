using System;


namespace _02.InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> simple = Extensions.GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compound = Extensions.GetCompoundInterest;

            var acc1 = new InterestCalculator(500m, 5.6m, 10, compound);
            var acc2 = new InterestCalculator(2500m, 7.2m, 15, simple);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
        }
    }
}

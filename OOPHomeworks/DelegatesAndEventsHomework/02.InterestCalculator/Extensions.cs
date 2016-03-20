using System;

namespace _02.InterestCalculator
{
    public static class Extensions
    {
        private const int InterestCompounded = 12;

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + ((interest / 100) / InterestCompounded)), years * InterestCompounded);
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + (interest / 100 * years));
        }
    }
}

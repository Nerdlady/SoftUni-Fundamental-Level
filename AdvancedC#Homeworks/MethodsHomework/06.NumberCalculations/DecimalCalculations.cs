namespace _06.NumberCalculations
{
    using System;

    public class DecimalCalculations
    {
        private decimal[] numbers;

        public DecimalCalculations(decimal[] numbers)
        {
            this.Numbers = numbers;
        }

        public decimal[] Numbers
        {
            get
            {
                return this.numbers;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Array cannot be with lenght 0");
                }
                this.numbers = value;
            }
        }

        public decimal GetMin()
        {
            decimal minElement = decimal.MaxValue;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                if (this.Numbers[index] < minElement)
                {
                    minElement = this.Numbers[index];
                }
            }
            return minElement;
        }

        public decimal GetMax()
        {
            decimal maxElement = decimal.MinValue;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                if (this.Numbers[index] > maxElement)
                {
                    maxElement = this.Numbers[index];
                }
            }
            return maxElement;
        }

        public decimal GetAverage()
        {
            decimal average = GetSum() / numbers.Length;
            return average;
        }

        public decimal GetSum()
        {
            decimal sum = 0;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                sum += this.Numbers[index];
            }
            return sum;
        }

        public decimal GetProduct()
        {
            decimal product = 1;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                product *= this.Numbers[index];
            }
            return product;
        }
    }
}

namespace _06.NumberCalculations
{
    using System;

    public class DoubleCalculations
    {
        private double[] numbers;
        public DoubleCalculations(double[] numbers)
        {
            this.Numbers = numbers;
        }

        public double[] Numbers
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

        public double GetMin()
        {
            double minElement = double.MaxValue;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                if (numbers[index] < minElement)
                {
                    minElement = numbers[index];
                }
            }
            return minElement;
        }
        
        public double GetMax()
        {
            double maxElement = double.MinValue;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                if (this.Numbers[index] > maxElement)
                {
                    maxElement = this.Numbers[index];
                }
            }
            return maxElement;
        }
        
        public double GetAverage()
        {
            double average = GetSum() / this.Numbers.Length;
            return average;
        }

        public double GetSum()
        {
            double sum = 0;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                sum += this.Numbers[index];
            }
            return sum;
        }

        public double GetProduct()
        {
            double product = 1;
            for (int index = 0; index < this.Numbers.Length; index++)
            {
                product *= this.Numbers[index];
            }
            return product;
        }


    }
}

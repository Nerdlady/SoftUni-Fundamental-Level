using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        public Int64 numerator;
        public Int64 denominator;

        public Fraction(Int64 numerator , Int64 denominator) : this()
        {
            this.Denominator = denominator;
            this.Numerator = numerator;
        }

        public static Fraction operator +(Fraction one , Fraction two)
        {
            return new Fraction((one.Numerator * two.Denominator) + (two.Numerator * one.Denominator), one.Denominator * two.Denominator);
        }

        public static Fraction operator -(Fraction one, Fraction two)
        {
            return new Fraction((one.Numerator * two.Denominator) - (two.Numerator * one.Denominator), one.Denominator * two.Denominator);
        }

        public Int64 Numerator 
        {
            get { return this.numerator; }
            set { this.numerator = value;}
        }

        public Int64 Denominator 
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominator cannot be 0");
                }
                this.denominator = value;
            }
        }

        

        public override string ToString()
        {
            return string.Format("{0}" , (double)this.numerator / (double)this.denominator);

            
        }
    }
}

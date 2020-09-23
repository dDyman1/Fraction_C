using System;

namespace HelloGithubClassroom
{
    public class Fraction
    {
        private int d;

        public Fraction(int num = 0, int den = 1)// default par must be compiler constants
        {
            Numerator = num;
            Denominator = den;
            Simplify();
        }

        private void Simplify()
        {
            if (Numerator < 0 && Denominator < 0)
            {
                Numerator *= -1;
                d *= -1;
            }
            Reduce();
        }

        private void Reduce()
        {
            int n = Numerator;
            int gcd = gcdVal(n, d);

            Numerator /= gcd;
            d /= gcd;
        }

        static int gcdVal(int a, int b)
        {
            if (b == 0)
                return a;
            return gcdVal(b, a % b);
        }

        public int Numerator { get; set; }

        public int Denominator
        {
            get
            {
                return d;
            }
            set
            {
                if (value == 0)
                    throw new ArgumentOutOfRangeException("denominator may not be 0");

                d = value;
            }
        }

        //Overloading Operators

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numer = (f1.Numerator * f2.Denominator) + (f2.Numerator * f1.Denominator);
            int denum = f1.Denominator * f2.Denominator;
            return new Fraction(numer, denum);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numer = (f1.Numerator * f2.Denominator) - (f2.Numerator * f1.Denominator);
            int denum = f1.Denominator * f2.Denominator;
            return new Fraction(numer, denum);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numer = f1.Numerator * f2.Numerator;
            int denum = f1.Denominator * f2.Denominator;
            return new Fraction(numer, denum);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int numer = f1.Numerator * f2.Denominator;
            int denum = f1.Denominator * f2.Numerator;
            return new Fraction(numer, denum);
        }

        public static Fraction operator +(Fraction f1, int val)
        {
            int numer = (f1.Numerator * 1) + (val * f1.Denominator);
            return new Fraction(numer, f1.Denominator * 1);
        }

        public static Fraction operator -(Fraction f1, int val)
        {
            int numer = (f1.Numerator * 1) - (val * f1.Denominator);
            return new Fraction(numer, f1.Denominator * 1);
        }

        public static Fraction operator *(Fraction f1, int val)
        {
            return new Fraction(f1.Numerator * val, f1.Denominator);
        }

        public static Fraction operator /(Fraction f1, int val)
        {
            return new Fraction(f1.Numerator, f1.Denominator * val);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fraction
            {
                Numerator = 2,
                Denominator = 3
            };

            Fraction test = new Fraction(6, 10);
            Fraction f3 = test / 3;
            Console.WriteLine(f3.Denominator);

        }
    }
}

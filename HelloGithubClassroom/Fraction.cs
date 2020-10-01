using System;
using System.Runtime.CompilerServices;

namespace FractionClassroom
{
    public class Fraction
    {
        private int d;

        public static implicit operator Fraction(int val) => new Fraction(val);
        public static implicit operator Fraction(double val)
        {
            String str = val + "";
            int subLength = str.Substring(str.IndexOf(".")+1).Length;
            int var = Int32.Parse(val.ToString().Replace(".", ""));
            subLength = (int)Math.Pow(10, subLength);
            return new Fraction(var, subLength); 
        }
        public static explicit operator double(Fraction f) => (double)f.Numerator / f.Denominator;
        public static explicit operator int(Fraction f) => f.Numerator / f.Denominator;

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
            if (d < 0 && Numerator > 0)
            {
                d *= -1;
                Numerator *= -1;
            }
        }

        static int gcdVal(int a, int b)
        {
            if (b == 0)
                return a;
            return gcdVal(b, a % b);
        }

        public int Numerator { get; private set; }

        public int Denominator
        {
            get
            {
                return d;
            }
            private set
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

        public static bool operator >(Fraction f1, Fraction f2)
        {
            double v1 = (double)f1;
            double v2 = (double)f2;
            return v1 > v2;

        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            double v1 = (double)f1;
            double v2 = (double)f2;
            return v1 < v2;

        }

        public static bool operator >=(Fraction f1, Fraction f2)
        {
            double v1 = (double)f1;
            double v2 = (double)f2;
            return v1 >= v2;
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            double v1 = (double)f1;
            double v2 = (double)f2;
            return v1 <= v2;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            double v1 = (double)f1;
            double v2 = (double)f2;
            return v1 == v2;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            double v1 = (double)f1;
            double v2 = (double)f2;
            return v1 != v2;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fraction(3, 5);

            Fraction test = new Fraction(4, 10);
            Fraction f3 = f - new Fraction(36,10);
            Console.WriteLine(((Fraction) (-3.07)).Numerator);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionClassroom;
using System;

namespace FractionTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NewFraction1()
        {
            Fraction fraction = new Fraction(0, 0);
            
        }

        [TestMethod]
        public void NewFraction2()
        {
            Fraction fraction = new Fraction(3);
            Assert.AreEqual(fraction.Numerator, 3);
            Assert.AreEqual(fraction.Denominator, 1);
        }

        [TestMethod]
        public void NewFraction3()
        {
            Fraction fraction = new Fraction(6, 14);
            Assert.AreEqual(fraction.Numerator, 3);
            Assert.AreEqual(fraction.Denominator, 7);
        }

        Fraction f1 = new Fraction(3, 5);
        Fraction f2 = new Fraction(2, 7);

        [TestMethod]
        public void TwoFractionAdd()
        {
            Fraction f = f1 + f2;
            Assert.AreEqual(f.Numerator, 31);
            Assert.AreEqual(f.Denominator, 35);
        }

        [TestMethod]
        public void TwoFractionSub()
        {
            Fraction f = f1 - f2;
            Assert.AreEqual(f.Numerator, 11);
            Assert.AreEqual(f.Denominator, 35);
        }

        [TestMethod]
        public void TwoFracMultiply()
        {
            Fraction f = f1 * f2;
            Assert.AreEqual(f.Numerator, 6);
            Assert.AreEqual(f.Denominator, 35);
        }

        [TestMethod]
        public void TwoFracDivide()
        {
            Fraction f = f1 / f2;
            Assert.AreEqual(f.Numerator, 21);
            Assert.AreEqual(f.Denominator, 10);
        }

        [TestMethod]
        public void IntFractionAdd()
        {
            Fraction f = f1 + 3;
            Assert.AreEqual(f.Numerator, 18);
            Assert.AreEqual(f.Denominator, 5);
        }

        [TestMethod]
        public void IntFractionSub()
        {
            Fraction f = f1 - 3;
            Assert.AreEqual(f.Numerator, -12);
            Assert.AreEqual(f.Denominator, 5);
        }

        [TestMethod]
        public void IntFracMultiply()
        {
            Fraction f = f1 * 3;
            Assert.AreEqual(f.Numerator, 9);
            Assert.AreEqual(f.Denominator, 5);
        }

        [TestMethod]
        public void IntFracDivide()
        {
            Fraction f = f1 / 3;
            Assert.AreEqual(f.Numerator, 1);
            Assert.AreEqual(f.Denominator, 5);
        }

        [TestMethod]
        public void DoubleFractionAdd()
        {
            Fraction f = f1 + 0.1;
            Assert.AreEqual(f.Numerator, 7);
            Assert.AreEqual(f.Denominator, 10);
        }

        [TestMethod]
        public void DoubleFractionSub()
        {
            Fraction f = f1 - 3.67;
            Assert.AreEqual(f.Numerator, -307);
            Assert.AreEqual(f.Denominator, 100);
        }

        [TestMethod]
        public void DoubleFracMultiply()
        {
            Fraction f = f1 * 3.25;
            Assert.AreEqual(f.Numerator, 39);
            Assert.AreEqual(f.Denominator, 20);
        }

        [TestMethod]
        public void DoubleFracDivide()
        {
            Fraction f = f1 / 2.71;
            Assert.AreEqual(f.Numerator, 60);
            Assert.AreEqual(f.Denominator, 271);
        }

        [TestMethod]

        public void GreaterThanTest()
        {
            Assert.AreEqual(f1 > f2, true);
            Assert.AreEqual(f2 > f1, false);
        }

        [TestMethod]
        public void GreaterOrEqTest()
        {
            Assert.AreEqual(f1 >= f2, true);
            Assert.AreEqual(f2 >= f1, false);
            Assert.AreEqual(f1 >= 0.6, true);
        }

        [TestMethod]

        public void LessThanTest()
        {
            Assert.AreEqual(f1 < f2, false);
            Assert.AreEqual(f2 < f1, true);
        }

        [TestMethod]
        public void LessOrEqTest()
        {
            Assert.AreEqual(f1 <= f2, false);
            Assert.AreEqual(f2 <= f1, true);
            Assert.AreEqual(f1 <= 0.6, true);
        }

        [TestMethod]

        public void EqualToTest()
        {
            Assert.AreEqual(f1 == f2, false);
            Assert.AreEqual(f1 == 0.6, true);
        }

        [TestMethod]
        public void NotEqualToTest()
        {
            Assert.AreEqual(f1 != f2, true);
            Assert.AreEqual(f1 != 0.6, false);
        }


    }
}

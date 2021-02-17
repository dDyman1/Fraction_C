using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionNS;
using System;

namespace FractionTesting
{
    [TestClass]
    public class UnitTest1
    {
        Fraction f1 = new Fraction(3, 5);
        Fraction f2 = new Fraction(2, 7);

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

    }
}
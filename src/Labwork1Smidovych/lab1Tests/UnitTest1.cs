using System;
using NUnit.Framework;
using TP2._4_Lab1;


namespace lab1Tests
{
    [TestFixture()]
    public class lab1Tests
    {
        [Test()]
        public void factorial5Exp120()
        {
            double x = 5;
            double expected = 120;
            lab1 t = new lab1();
            double actual = t.getFactorial(x);
            Assert.AreEqual(expected, actual);

        }
        [Test()]
        public void checkSizeTrue()
        {
            double x = -34581;
            bool expected = true;
            lab1 t = new lab1();
            bool actual = t.checkNum(x);
            Assert.AreEqual(expected, actual);

        }
        [Test()]
        public void checkSizeFalse()
        {
            double x = 9999999999;
            bool expected = false;
            lab1 t = new lab1();
            bool actual = t.checkNum(x);
            Assert.AreEqual(expected, actual);

        }
        [Test()]
        public void checkFormatTrue()
        {
            string x = "123,456";
            bool expected = true;
            lab1 t = new lab1();
            bool actual = t.formatCheck(x);
            Assert.AreEqual(expected, actual);

        }
        [Test()]
        public void checkFormatFalse()
        {
            string x = "-12qw34.56+7";
            bool expected = false;
            lab1 t = new lab1();
            bool actual = t.formatCheck(x);
            Assert.AreEqual(expected, actual);

        }
    }
}

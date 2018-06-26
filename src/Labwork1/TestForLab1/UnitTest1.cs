using System;
using NUnit.Framework;
using TP2._4_Lab1;

namespace testForLab1
{
    [TestFixture()]
    public class UnitTest1
    {
        lab1 test = new lab1();
        [Test()]
        public void factorial1()
        {
            double x = 5;
            double expected = 120;
            double actual = test.getFactorial(x);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void factorial2()
        {
            int x = 4;
            int expected = 24;
            double actual = test.getFactorial(x);
            Assert.AreEqual(expected, actual);
        }
    }
}

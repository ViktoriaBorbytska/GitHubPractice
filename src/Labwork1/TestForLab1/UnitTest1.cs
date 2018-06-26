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
        public void add1()
        {
            double x = 5;
            double y = 115;
            double expected = 120;
            double actual = test.addFunk(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void add2()
        {
            double x = 10;
            double y = 15;
            double expected = 25;
            double actual = test.addFunk(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using NUnit.Framework;
using TP_lab4_2_class;

namespace UnitTestLab4
{
    [TestFixture()]
    public class UnitTest1
    {
        Tmas test = new Tmas();
        [Test()]
        public void add1()
        {
            test.x = 3;
            test.y = 5;
            int expected = 8;
            int actual = test.add();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void add2()
        {
            test.x = 13;
            test.y = 53;
            int expected = 66;
            int actual = test.add();
            Assert.AreEqual(expected, actual);
        }
    }
}

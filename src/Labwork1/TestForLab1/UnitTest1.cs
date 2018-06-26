using NUnit.Framework;
using ClassLibrary2;

namespace testForLab1
{
    [TestFixture()]
    public class UnitTest1
    {
        Class1 test = new Class1();
        [Test()]
        public void add1()
        {
            double x = 5;
            double y = 115;
            double expected = 120;
            double actual = test.add(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void add2()
        {
            double x = 10;
            double y = 15;
            double expected = 25;
            double actual = test.add(x, y);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void add3()
        {
            double x = 99;
            double y = 66;
            double expected = 165;
            double actual = test.add(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}

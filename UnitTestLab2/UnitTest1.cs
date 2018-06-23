using lab2;
using NUnit.Framework;

namespace UnitTestLab2
{
    [TestFixture()]
    public class UnitTest1
    {
        Form1 t = new Form1();
        [Test()]
        public void formatVerificationTrue()
        {
            string a = "123.456";
            bool expected = true;
            bool actual = t.formatVerification(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void formatVerificationFalse()
        {
            string a = "-12qw34.56+7";
            bool expected = false;
            bool actual = t.formatVerification(a);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerificationTrue()
        {
            string a = "-123.456";
            string b = "0";
            string c = "546";
            bool expected = true;
            bool actual = t.inputVerification(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerificationFalse()
        {
            string a = "zx134cs";
            string b = "";
            string c = "9999999";
            bool expected = false;
            bool actual = t.inputVerification(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator1()
        {
            string a = "0";
            string b = "0";
            string c = "0";
            string expected = "any value";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator2()
        {
            string a = "0";
            string b = "0";
            string c = "78";
            string expected = "equation is incorrect";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator3()
        {
            string a = "0";
            string b = "-65";
            string c = "0";
            string expected = "0";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator4()
        {
            string a = "0";
            string b = "5";
            string c = "-65";
            string expected = "13";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator5()
        {
            string a = "7";
            string b = "-49";
            string c = "0";
            string expected = "0";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator6()
        {
            string a = "1";
            string b = "4";
            string c = "3";
            string expected = "-1";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator7()
        {
            string a = "1";
            string b = "4";
            string c = "4";
            string expected = "-2";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void firstRootCalculator8()
        {
            string a = "7";
            string b = "4";
            string c = "4";
            string expected = "-0.286 + 0.7* i";
            Class1 t = new Class1(a, b, c);
            string actual = t.firstRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator1()
        {
            string a = "0";
            string b = "0";
            string c = "0";
            string expected = "any value";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator2()
        {
            string a = "0";
            string b = "0";
            string c = "78";
            string expected = "equation is incorrect";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator3()
        {
            string a = "0";
            string b = "-65";
            string c = "0";
            string expected = "0";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator4()
        {
            string a = "0";
            string b = "5";
            string c = "-65";
            string expected = "13";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator5()
        {
            string a = "7";
            string b = "-49";
            string c = "0";
            string expected = "7";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator6()
        {
            string a = "1";
            string b = "4";
            string c = "3";
            string expected = "-3";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator7()
        {
            string a = "1";
            string b = "4";
            string c = "4";
            string expected = "-2";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void secondRootCalculator8()
        {
            string a = "7";
            string b = "4";
            string c = "4";
            string expected = "-0.286 - 0.7* i";
            Class1 t = new Class1(a, b, c);
            string actual = t.secondRootCalculator();
            Assert.AreEqual(expected, actual);
        }
    }
}

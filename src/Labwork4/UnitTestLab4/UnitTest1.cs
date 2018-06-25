using System;
using NUnit.Framework;
using TP_lab4_2_class;

namespace UnitTestLab4
{
    [TestFixture()]
    public class UnitTest1
    {
        Tmas test = new Tmas();
        int INF = 999999999;

        [Test()]
        public void checkAll10()
        {
            string x = "";
            string y = "";
            string lower = "";
            string upper = "";
            int expected = 10;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll0()
        {
            string x = "qwer";
            string y = "";
            string lower = "";
            string upper = "";
            int expected = 0;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll1()
        {
            string x = "689";
            string y = "";
            string lower = "";
            string upper = "";
            int expected = 1;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll2()
        {
            string x = "12";
            string y = "-4.5";
            string lower = "";
            string upper = "";
            int expected = 2;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll3()
        {
            string x = "12";
            string y = "740";
            string lower = "";
            string upper = "";
            int expected = 3;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll4()
        {
            string x = "12";
            string y = "45";
            string lower = "";
            string upper = "";
            int expected = 4;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll5()
        {
            string x = "12";
            string y = "45";
            string lower = "920";
            string upper = "";
            int expected = 5;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll6()
        {
            string x = "12";
            string y = "45";
            string lower = "20";
            string upper = "1w2";
            int expected = 6;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll7()
        {
            string x = "12";
            string y = "45";
            string lower = "20";
            string upper = "145";
            int expected = 7;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkAll8()
        {
            string x = "12";
            string y = "45";
            string lower = "50";
            string upper = "30";
            int expected = 8;
            int actual = test.checkAll(x, y, lower, upper);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkText1()
        {
            string textToCheck = "";
            bool expected = false;
            bool actual = test.checkText(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkText2()
        {
            string textToCheck = "qwe";
            bool expected = false;
            bool actual = test.checkText(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkText3()
        {
            string textToCheck = "53";
            bool expected = true;
            bool actual = test.checkText(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        public void checkTextС1()
        {
            string textToCheck = "";
            bool expected = false;
            bool actual = test.checkTextC(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkTextС2()
        {
            string textToCheck = "qwe";
            bool expected = false;
            bool actual = test.checkTextC(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkTextС3()
        {
            string textToCheck = "-53";
            bool expected = true;
            bool actual = test.checkTextC(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkС1()
        {
            string textToCheck = "io";
            bool expected = false;
            bool actual = test.checkC(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void checkС2()
        {
            string textToCheck = "-53";
            bool expected = true;
            bool actual = test.checkC(textToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void operation1()
        {
            test.x = 3;
            test.y = 3;
            int[,] arrForTest = new int[3, 3] { { 78, 13, 24 }, { 67, 99, 17 }, { 56, 9, 46 } };
            test.array = arrForTest;
            string expected = "Минимальный элемент среди элементов с четной суммой индексов массива 24";
            string actual = test.operation1();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void operation2()
        {
            test.x = 3;
            test.y = 3;
            int[,] arrForTest = new int[3, 3] { { 78, 13, 24 }, { 67, 99, 17 }, { 56, 9, 46 } };
            int[,] arrForCompare = new int[3, 3] { { 13, 24, 78 }, { 17, 67, 99 }, { 9, 46, 56 } };
            test.array = arrForTest;
            int[,] actualArr = test.operation2();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int expected = arrForCompare[i, j];
                    int actual = actualArr[i, j];
                    Assert.AreEqual(expected, actual);
                }
            }
        }
        [Test()]
        public void operation3()
        {
            test.x = 3;
            test.y = 3;
            string c = "5";
            int[,] arrForTest = new int[3, 3] { { 78, 13, 24 }, { 67, 99, 17 }, { 56, 9, 46 } };
            int[,] arrForCompare = new int[3, 3] { { 83, 18, 29 }, { 72, 104, 22 }, { 61, 14, 51 } };
            test.array = arrForTest;
            int[,] actualArr = test.operation3(c);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int expected = arrForCompare[i, j];
                    int actual = actualArr[i, j];
                    Assert.AreEqual(expected, actual);
                }
            }
        }

    }
}

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
        public void operation1()
        {
            test.x = 3;
            test.y = 3;
            int[,] arrForTest = new int[3, 3] { { 78, 13, 24 }, { 67, 99, 17 }, { 56, 9, 46 } };
            test.array = arrForTest;
            string expected = "Minimal element is 24";
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
    }
}

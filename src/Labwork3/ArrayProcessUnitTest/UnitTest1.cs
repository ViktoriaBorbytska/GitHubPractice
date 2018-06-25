using NUnit.Framework;
using ArrayClassLibrary;

namespace ArrayProcessUnitTest
{
    [TestFixture()]
    public class UnitTest1
    {
        arrayProcessingClass testClass = new arrayProcessingClass();

        [Test()]
        public void formatVerificationTrue()
        {
            bool expected = true;
            bool actual = testClass.formatVerification("478");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void formatVerificationFalse()
        {
            bool expected = false;
            bool actual = testClass.formatVerification("qe53");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void cValueVerificationTrue()
        {
            bool expected = true;
            bool actual = testClass.cValueVerification("135");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void cValueVerificationFalse()
        {
            bool expected = false;
            bool actual = testClass.cValueVerification("");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification0()
        {
            int expected = 0;
            int actual = testClass.inputVerification("qwert", "563", "778");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification1()
        {
            int expected = 1;
            int actual = testClass.inputVerification("1256", "563", "778");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification2()
        {
            int expected = 2;
            int actual = testClass.inputVerification("57", "", "778");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification3()
        {
            int expected = 3;
            int actual = testClass.inputVerification("57", "7890", "778");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification4()
        {
            int expected = 4;
            int actual = testClass.inputVerification("57", "563", "77,8");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification5()
        {
            int expected = 5;
            int actual = testClass.inputVerification("57", "563", "9234");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification6()
        {
            int expected = 6;
            int actual = testClass.inputVerification("57", "778", "563");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void inputVerification7()
        {
            int expected = 7;
            int actual = testClass.inputVerification("57", "563", "778");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void getArray()
        {
            int[] expectedArr = { 999999, 4 };
            int[] actualArr = testClass.getArray("57", "563", "77,8");
            for (int i = 0; i < 2; i++)
            {
                int expected = expectedArr[i];
                int actual = actualArr[i];
                Assert.AreEqual(expected, actual);
            }
        }
        [Test()]
        public void function1()
        {
            testClass.IsArrayExisting = true;
            testClass.numOfElems = 5;
            testClass.array = new int[] { 1, 2, 3, 4, 5 };
            string expected = "Min: 1; Max: 5; Median: 3";
            string actual = testClass.function1();
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void function2()
        {
            testClass.IsArrayExisting = true;
            testClass.numOfElems = 5;
            testClass.array = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedArr = { 5, 4, 3, 2, 1 };
            int[] actualArr = testClass.function2();
            for (int i = 0; i < testClass.numOfElems; i++)
            {
                int expected = expectedArr[i];
                int actual = actualArr[i];
                Assert.AreEqual(expected, actual);
            }
        }
        [Test()]
        public void function3True()
        {
            testClass.IsArrayExisting = true;
            testClass.numOfElems = 6;
            testClass.array = new int[] { 1, 2, 3, 4, 5, 6 };
            string expected = "Sum: 10. Number in total: 2";
            string actual = testClass.function3("3");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void function3False()
        {
            testClass.IsArrayExisting = true;
            testClass.numOfElems = 5;
            testClass.array = new int[] { 1, 2, 3, 4, 5 };
            string expected = "Invalid C format!";
            string actual = testClass.function3("q45q");
            Assert.AreEqual(expected, actual);
        }
        [Test()]
        public void function4()
        {
            testClass.IsArrayExisting = true;
            testClass.numOfElems = 5;
            testClass.array = new int[] { 410, 220, 30, 293, 353 };
            string expected = "Sum: 250. Number in total: 2";
            string actual = testClass.function4();
            Assert.AreEqual(expected, actual);
        }
    }
}



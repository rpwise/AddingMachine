using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddTwoNumbersInts()
        {
            // add 1 and 2
            var int1 = 1;
            var int2 = 2;
            var total = Calcultions.AddTwoNumbers(int1, int2);

            Assert.AreEqual(total, 3);
        }

        [TestMethod]
        public void TestAddTwoNumbersString()
        {
            // add 1 and 2
            var string1 = "1";
            var string2 = "2";
            var total = Calcultions.AddTwoNumbers(string1, string2);

            Assert.AreEqual(total, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "var1")]
        public void TestAddTwoNumbersStringNull1()
        {
            // add 1 and 2
            var string1 = string.Empty;
            var string2 = "2";
            var total = Calcultions.AddTwoNumbers(string1, string2);

            Assert.AreEqual(total, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "var1")]
        public void TestAddTwoNumbersStringNull2()
        {
            // add 1 and 2
            var string1 = "1";
            var string2 = string.Empty;
            var total = Calcultions.AddTwoNumbers(string1, string2);

            Assert.AreEqual(total, 3);
        }
    }
}
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
    }
}
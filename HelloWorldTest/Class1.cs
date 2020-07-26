using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.AlgorithmPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
    [TestClass]
    public class RecursionsTest
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var testString = "reverse this string";

            Assert.AreEqual(Recursion.ReverseString(testString), "gnirts siht esrever");

        }
        [TestMethod]
        public void ReverseStringRecursiveTest()
        {
            var testString = "reverse this string";

            Assert.AreEqual(Recursion.ReverseStringRecursive(testString), "gnirts siht esrever");

        }

        [TestMethod]
        public void GetSumBetweenNumbersTest()
        {
            int min = 0;
            int max = 10;

            Assert.AreEqual(Recursion.GetSumBetweenNumbers(min, max), 55);

            min = 0;
            max = 1;

            Assert.AreEqual(Recursion.GetSumBetweenNumbers(min, max), 1);

        }
    }
}

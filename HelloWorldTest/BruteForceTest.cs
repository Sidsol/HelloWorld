using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.AlgorithmPractice;


namespace HelloWorldTest
{
    [TestClass]
    public class BruteForceTest
    {
        [TestMethod]
        public void IsBruteForceTest()
        {
            var testString = "this string has multiple t's in it";
            var testString2 = "No repeated first Character";

            Assert.IsTrue(BruteForce.IsFirstCharRepeated(testString));
            Assert.IsFalse(BruteForce.IsFirstCharRepeated(testString2));

        }
    }
}

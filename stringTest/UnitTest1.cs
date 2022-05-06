using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace maxOfThree.tests
{
    [TestClass()]
    public class UsingstringsTests
    {
        [TestMethod()]
        public void MaximumstringTest()
        {
            usingstring usingstrings = new usingstring();
            string result = usingstrings.Maximum("wheat", "rice", "pulse");
            Assert.AreEqual("wheat", result);

        }
        [TestMethod()]
        public void MaximumstringTest2()
        {
            usingstring usingstrings1 = new usingstring();
            string result1 = usingstrings1.Maximum("rice", "wheat", "pulse");
            Assert.AreEqual("wheat", result1);
        }
        [TestMethod()]
        public void MaximumstringTest3()
        {
            usingstring usingstrings2 = new usingstring();
            string result2 = usingstrings2.Maximum("pulse", "rice", "wheat");
            Assert.AreEqual("Banana", result2);
        }
    }
}

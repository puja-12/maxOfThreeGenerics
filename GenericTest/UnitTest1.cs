using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace maxOfThree.Tests
{
    [TestClass()]
    public class GenericClassTests
    {
        [TestMethod()]
        public void MaxGenericsTest()
        {
            int value = GenericClass.Maximum<int>(4, 3, 2);
            Assert.AreEqual(4, value);
        }
        [TestMethod()]
        public void MaxGenericsTest1()
        {
            double value = GenericClass.Maximum<double>(1.1, 5.5, 4.4);
            Assert.AreEqual(5.5, value);
        }
        [TestMethod()]
        public void MaxGenericsTest2()
        {
            string value = GenericClass.Maximum<string>("pulse", "rice", "wheat");
            Assert.AreEqual("wheat", value);
        }
    }
}
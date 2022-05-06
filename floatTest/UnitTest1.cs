using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace maxOfThree.Tests
{

    [TestClass()]
    public class usingfloatTests
    {
        [TestMethod()]
        public void MaximumfloatTest()
        {
            usingfloat Usingfloat = new usingfloat();
            double result = Usingfloat.Maximumfloat(5.2, 3.5, 1.4);
            Assert.AreEqual(5.2, result);

        }
        [TestMethod()]
        public void MaximumfloatTest2()
        {
            usingfloat Usingfloat1 = new usingfloat();
            double result1 = Usingfloat1.Maximumfloat(2.3, 6.6, 5.4);
            Assert.AreEqual(6.6, result1);
        }
        [TestMethod()]
        public void MaximumfloatTest3()
        {
            usingfloat Usingfloat2 = new usingfloat();
            double result2 = Usingfloat2.Maximumfloat(1.3, 2.7, 8.8);
            Assert.AreEqual(8.8, result2);
        }
    }
}
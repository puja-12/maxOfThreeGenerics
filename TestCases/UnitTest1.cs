using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace maxOfThree.Tests
{
    [TestClass()]
    public class UsingIntTests
    {
        [TestMethod()]
        public void MaximumTest1()
        {
            usingInt int1
                = new usingInt();
            int result = int1.Maximum(6, 2, 4);
            Assert.AreEqual(6, result);

        }
        [TestMethod()]
        public void MaximumTest2()
        {
            usingInt int2 = new usingInt();
            int result1 = int2.Maximum(3, 7, 6);
            Assert.AreEqual(7, result1);
        }
        [TestMethod()]
        public void MaximumTest3()
        {
            usingInt int3 = new usingInt();
            int result2 = int3.Maximum(3, 7, 8);
            Assert.AreEqual(8, result2);
        }
    }
}
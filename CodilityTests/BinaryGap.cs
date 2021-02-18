using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.BinaryGap;

namespace CodilityTests
{
    [TestClass]
    public class UnitTest1
    {
        BinaryGap bg = new BinaryGap();
        
        [TestMethod]
        public void TestBinaryGap9()
        {
            int n = 9;
            Assert.IsTrue(bg.solution(n) == 2);
        }

        [TestMethod]
        public void TestBinaryGap0()
        {
            int n = 0;
            Assert.IsTrue(bg.solution(n) == 0);
        }

        [TestMethod]
        public void TestBinaryGap1041()
        {
            int n = 1041;
            Assert.IsTrue(bg.solution(n) == 5);
        }

        [TestMethod]
        public void TestBinaryGap92()
        {
            int n = 9;
            Assert.IsTrue(bg.solution2(n) == 2);
        }

        [TestMethod]
        public void TestBinaryGap02()
        {
            int n = 0;
            Assert.IsTrue(bg.solution2(n) == 0);
        }

        [TestMethod]
        public void TestBinaryGap10412()
        {
            int n = 1041;
            Assert.IsTrue(bg.solution2(n) == 5);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility.TimeComplexity;
namespace CodilityTests
{
    [TestClass]
    public class FogJumpTests
    {
        FogJump fg = new FogJump();
        [TestMethod]
        public void FogJumpTest()
        {
            int expected = 3;
            Assert.IsTrue(fg.solution(10, 85, 30) == expected);
        }
    }
}

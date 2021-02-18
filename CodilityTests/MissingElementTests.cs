using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility.TimeComplexity;
namespace CodilityTests
{
    [TestClass]
    public class MissingElementTests
    {
        MissingElement missE = new MissingElement();
        [TestMethod]
        public void MissingTest()
        {
            int expected = 4;
            int[] input = new int[] { 1, 2, 3, 5 };
            Assert.IsTrue(expected == missE.solution(input));
        }
    }
}

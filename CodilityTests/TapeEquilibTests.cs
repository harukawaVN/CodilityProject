using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility.TimeComplexity;
namespace CodilityTests
{
    [TestClass]
    public class TapeEquilibTests
    {
        TapeEquilib tap = new TapeEquilib();
        [TestMethod]
        public void TapeEquilibTest()
        {
            int expected = 1;
            int[] input = new int[] { 3, 1, 2, 4, 3 };
            Assert.IsTrue(expected == tap.solution1(input));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility.Arrays;
namespace CodilityTests
{
    [TestClass]
    public class CyclicRotationTests
    {
        CyclicRotation cr = new CyclicRotation();
        [TestMethod]
        public void CyclicRotationTest()
        {
            int[] expected = new int[] { 9, 7, 6, 3, 8 };
            int[] input = new int[] { 3, 8, 9, 7, 6 };
            CollectionAssert.Equals(expected, cr.solution1(input, 3));
        }
    }
}

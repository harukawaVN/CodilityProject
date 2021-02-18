using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Arrays;

namespace CodilityTests
{
    [TestClass]
    public class OddOccurenceInArrayTests
    {
        OddOccurrencesInArray arrayTest = new OddOccurrencesInArray();
        [TestMethod]
        public void TestOddArray1()
        {
            int[] array = new int[]{ 1,1,3,2,2,4,4};
            int expected = 3;
            Assert.IsTrue(arrayTest.solution1(array) == expected);
        }

        [TestMethod]
        public void TestOddArray2()
        {
            int[] array = new int[] { 1, 1, 3, 2, 2, 4, 4 };
            int expected = 3;
            Assert.IsTrue(arrayTest.solution2(array) == expected);
        }

        [TestMethod]
        public void TestOddArray3()
        {
            int[] array = new int[] { 1, 1, 3, 2, 2, 4, 4 };
            int expected = 3;
            Assert.IsTrue(arrayTest.solution3(array) == expected);
        }
    }
}

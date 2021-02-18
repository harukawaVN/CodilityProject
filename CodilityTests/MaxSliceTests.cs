using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.MaxSlice;
namespace CodilityTests
{
    [TestClass]
    public class MaxSliceTests
    {
        SumMax sumMax = new SumMax();
        [TestMethod]
        public void MaxSliceTest()
        {
            int[] numbers = new int[] {3, 2, -6, 4, 0 };
            Assert.IsTrue(sumMax.solution(numbers) == 5);
        }

        MaxProfit profit = new MaxProfit();
        [TestMethod]
        public void MaxprofitTest()
        {
            int[] numbers = new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };
            Assert.IsTrue(profit.solution(numbers) == 356);
        }

        MaxDoubleSlice doubleSlice = new MaxDoubleSlice();
        [TestMethod]
        public void DoubleSliceTest()
        {
            int[] numbers = new int[] { 3, 2, 6, -1, 4, 5, -1 , 2 };
            Assert.IsTrue(doubleSlice.solution(numbers) == 17);
        }
    }
}
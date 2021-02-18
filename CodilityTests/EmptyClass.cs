using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.PrefixSum;
namespace CodilityTests
{
    [TestClass]
    public class PefixSumTests
    {
        PassingCars pc = new PassingCars();
        [TestMethod]
        public void PassingCars()
        {
            int[] cars = new int[] { 0, 1, 0, 1, 1 };
            Assert.IsTrue(pc.solution(cars) == 5);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Leader;
namespace CodilityTests
{
    [TestClass]
    public class DominatorTests
    {
        Dominator dom = new Dominator();
        [TestMethod]
        public void DominatorTest()
        {
            int[] input = new int[] { 2, 4, 3, 3, 3, -1, 3, 3 };
            Assert.IsTrue(dom.solution(input) == 3);
        }

        EquiLeader lead = new EquiLeader();
        [TestMethod]
        public void EquiLeaderTest()
        {
            int[] input = new int[] { 4, 3, 4, 4, 4, 2};
            Assert.IsTrue(lead.solution(input) == 2);
        }
    }
}

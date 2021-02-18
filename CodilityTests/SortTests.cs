using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Sorts;
namespace CodilityTests
{
    [TestClass]
    public class SortTests
    {
        QuickSort qs = new QuickSort();
        [TestMethod]
        public void QuickSortTests()
        {
            int[] array = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int[] expected = new int[] { -4, 0, 2, 5, 6, 11, 18, 22, 51, 67 };
            qs.Quick_Sort(array, 0, array.Length - 1);
            CollectionAssert.Equals(expected, array);
        }
    }
}

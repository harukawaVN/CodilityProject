using System;
using System.Linq;
namespace Codility.TimeComplexity
{
    public class TapeEquilib
    {
        public TapeEquilib()
        {
        }

        public int solution1(int[] array)
        {
            int left = array[0];
            int right = array.Sum() - left;
            int diff = Math.Abs(left - right);
            for (int i = 1; i < array.Length; i++)
            {
                left += array[i];
                right -= array[i];
                diff = Math.Min(diff, Math.Abs(left - right));
            }

            return diff;
        }
    }
}

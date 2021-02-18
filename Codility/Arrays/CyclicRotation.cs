using System;
namespace Codility.Arrays
{
    public class CyclicRotation
    {
        public CyclicRotation()
        {
        }

        public int[] solution1(int[] array, int k)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[(i + k) % array.Length];
            }

            return result;
        }
    }
}

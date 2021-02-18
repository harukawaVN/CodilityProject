using System;
namespace Codility.MaxSlice
{
    public class MaxDoubleSlice
    {
        public MaxDoubleSlice()
        {
        }

        public int solution(int[] A)
        {
            int[] forwLocalMax = new int[A.Length];
            int[] backLocalMax = new int[A.Length];

            //start from i=1 because slice can't start at index 0
            for (int i = 1; i < A.Length - 1; i++)
            {
                forwLocalMax[i] = Math.Max(forwLocalMax[i - 1] + A[i], 0);
            } //start from i=A.length-2 because slice can't end at index A.length-1
            for (int i = A.Length - 2; i > 0; i--)
            {
                backLocalMax[i] = Math.Max(backLocalMax[i + 1] + A[i], 0);
            }

            int maxDoubleSliceSum = 0;

            //compute sums of all slices to find absolute max
            for (int i = 1; i < A.Length - 1; i++)
            {
                maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, forwLocalMax[i - 1] + backLocalMax[i + 1]);
            }

            return maxDoubleSliceSum;
        }
    }
}

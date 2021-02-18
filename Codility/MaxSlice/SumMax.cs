using System;
namespace Codility.MaxSlice
{
    public class SumMax
    {
        public SumMax()
        {
        }

        public int solution(int[] numbers)
        {
            int maxSum = numbers[0];
            int max = maxSum; 
            for (int i = 0; ++ i < numbers.Length;)
            {
                maxSum = Math.Max(maxSum + numbers[i], numbers[i]);
                max = Math.Max(max, maxSum);
            }

            return max;
        }
    }
}

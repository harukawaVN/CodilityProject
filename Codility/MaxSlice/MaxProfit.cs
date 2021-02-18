using System;
namespace Codility.MaxSlice
{
    public class MaxProfit
    {
        public MaxProfit()
        {
        }

        public int solution(int[] numbers)
        {
            int[] profits = new int[numbers.Length - 1];
            for (int i = -1; ++ i < profits.Length;)
            {
                profits[i] = numbers[i + 1] - numbers[i];
            }

            return solutionMax(profits);
        }

        public int solutionMax(int[] numbers)
        {
            int maxSum = numbers[0];
            int max = maxSum;
            for (int i = 0; ++i < numbers.Length;)
            {
                maxSum = Math.Max(maxSum + numbers[i], numbers[i]);
                max = Math.Max(max, maxSum);
            }

            return max;
        }
    }
}

using System;
using System.Linq;
namespace Codility.TimeComplexity
{
    public class MissingElement
    {
        public MissingElement()
        {
        }

        public int solution(int[] array)
        {
            int n = array.Length + 1;
            int expectedSum = n * (n + 1) / 2;
            int sum = array.Sum();
            return expectedSum - sum;
        }
    }
}

using System;
namespace Codility.TimeComplexity
{
    public class FogJump
    {
        public FogJump()
        {
        }

        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((double)(Y - X) / D);
        }
    }
}

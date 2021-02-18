using System;
namespace Codility.BinaryGap
{
    public class BinaryGap
    {
        public BinaryGap()
        {
        }
		public int solution(int N)
		{
			bool started = false;
			int length = 0, max = 0;
			for (uint i = 1; i <= N; i <<= 1)
			{
				if ((i & N) != 0)
				{
					if (started)
					{
						if (length > max)
							max = length;
						length = 0;
					}
					started = true;
				}
				else if (started)
					++length;
			}
			return max;
		}

        public int solution2(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int i = N;
            int counter = 0;
            int result = 0;
            bool found_one = false;

            while (i > 0)
            {
                if ((i & 1) == 1)
                {
                    if (found_one == false)
                    {
                        found_one = true;
                    }
                    else
                    {
                        result = Math.Max(result, counter);
                    }
                    counter = 0;
                }
                else
                {
                    counter++;
                }

                i >>= 1;

                // i /= 2;

            }

            return result;

        }

        static int Solution3(int N)
        {
            int Longest = 0, ZeroCtr = 0;

            foreach (char c in Convert.ToString(N, 2))
            {
                if (c == '0')
                    ZeroCtr++;
                else
                {
                    if (ZeroCtr > Longest)
                        Longest = ZeroCtr;
                    ZeroCtr = 0;
                }
            }

            return Longest;
        }
    }
}

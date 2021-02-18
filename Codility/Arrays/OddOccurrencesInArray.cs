using System;
using System.Collections.Generic;
using System.Linq;
namespace Codility.Arrays
{
    public class OddOccurrencesInArray
    {
        public OddOccurrencesInArray()
        {
        }

        public int solution1(int[] numbers)
        {
            HashSet<int> table = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (table.Contains(numbers[i]))
                    table.Remove(numbers[i]);
                else
                    table.Add(numbers[i]);
            }

            foreach (var i in table)
                return i;
            return 0;
        }

        public int solution2(int[] numbers)
        {
            int unpaired = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                unpaired ^= numbers[i]; // Bitwise XOR
            }

            return unpaired;
        }

        public int solution3(int[] numbers)
        {
            Dictionary<int,int> table = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (table.ContainsKey(numbers[i]))
                    table[numbers[i]]++;
                else
                    table.Add(numbers[i], 1) ;
            }

            foreach (var i in table.Keys)
                if (table[i] % 2 != 0)
                    return i;
            return 0;
        }
    }
}

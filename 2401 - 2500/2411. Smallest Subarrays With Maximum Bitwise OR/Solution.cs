using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SmallestSubarraysWithMaximumBitwiseOR
{
    public class Solution
    {
        public int[] SmallestSubarrays(int[] nums)
        {
            var bits = Enumerable.Range(0, 32).Select(_ => new Queue<int>()).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                int bidx = 0;
                while (n > 0)
                {
                    if ((n & 1) > 0)
                        bits[bidx].Enqueue(i);
                    n >>= 1;
                    bidx++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var max = 1;
                for (int j = 0; j < bits.Length; j++)
                {
                    while (bits[j].TryPeek(out var idx) && idx < i)
                        bits[j].Dequeue();
                    if (bits[j].Count > 0)
                        max = Math.Max(max, bits[j].Peek() - i + 1);
                }
                nums[i] = max;
            }
            return nums;
        }
    }

    public class Solution_TLE
    {
        public int[] SmallestSubarrays(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var or = nums[i];
                nums[i] = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((or | nums[j]) > or)
                        nums[i] = j - i + 1;
                    or |= nums[j];
                }
            }
            return nums;
        }
    }
}
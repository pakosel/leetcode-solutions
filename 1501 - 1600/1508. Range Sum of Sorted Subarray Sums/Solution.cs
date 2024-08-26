using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RangeSumOfSortedSubarraySums
{
    public class Solution
    {
        public int RangeSum(int[] nums, int n, int left, int right)
        {
            const int MOD = 1_000_000_007;
            var pq = new PriorityQueue<int, int>();
            for (int i = 0; i < n; i++)
                Sum(i);
            while (--left > 0)
            {
                pq.Dequeue();
                right--;
            }
            long res = 0;
            while (right-- > 0)
            {
                res += pq.Dequeue();
                res %= MOD;
            }
            return (int)res;

            void Sum(int pos)
            {
                var val = nums[pos];
                pq.Enqueue(val, val);
                for (int i = pos + 1; i < n; i++)
                {
                    val += nums[i];
                    pq.Enqueue(val, val);
                }
            }
        }
    }
}
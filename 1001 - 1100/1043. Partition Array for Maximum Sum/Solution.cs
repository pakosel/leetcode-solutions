using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PartitionArrayForMaximumSum
{
    public class Solution
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            var memo = new Dictionary<(int, int), int>();
            return Memo(0, arr.Length - 1);

            int Memo(int start, int end)
            {
                var key = (start, end);
                if (memo.ContainsKey(key))
                    return memo[key];
                if (end - start == 0)
                    return arr[start];
                if (end - start < k)
                    return arr[start..].Max() * (end - start + 1);

                var take = 0;
                var max = 0;
                for (int i = 1; i <= k; i++)
                {
                    max = Math.Max(max, arr[start + i - 1]);
                    take = Math.Max(take, max * i + Memo(start + i, end));
                }

                memo[key] = take;
                return take;
            }
        }
    }
}
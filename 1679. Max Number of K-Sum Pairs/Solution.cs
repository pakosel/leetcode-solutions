using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaxNumberOfKSumPairs
{
    public class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
                if (!dict.ContainsKey(n))
                    dict.Add(n, 1);
                else
                    dict[n]++;
            var res = 0;
            foreach (var n in nums)
                if (dict[n] > 0 && dict.ContainsKey(k - n) && dict[k - n] > 0)
                {
                    if (n == k - n && dict[n] < 2)
                        continue;
                    dict[n]--;
                    dict[k - n]--;
                    res++;
                }
            return res;
        }
    }
}
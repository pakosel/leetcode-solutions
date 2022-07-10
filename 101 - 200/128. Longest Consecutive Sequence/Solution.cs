using System.Collections.Generic;
using System.Linq;
using System;

namespace LongestConsecutiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var res = 0;
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (dict.ContainsKey(n))
                    continue;
                var left = dict.ContainsKey(n - 1) ? dict[n - 1] : 0;
                var right = dict.ContainsKey(n + 1) ? dict[n + 1] : 0;
                var curr = left + right + 1;

                dict.Add(n, curr);
                res = Math.Max(res, curr);
                if (left > 0)
                    dict[n - left] = curr;
                if (right > 0)
                    dict[n + right] = curr;
            }
            return res;

        }
    }
}
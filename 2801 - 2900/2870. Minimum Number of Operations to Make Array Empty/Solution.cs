using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumNumberOfOperationsToMakeArrayEmpty
{
    public class Solution
    {
        public int MinOperations(int[] nums)
        {
            const int MAX = 1_000_000;
            var dict = new Dictionary<int, int>();
            var memo = new Dictionary<int, int>();

            foreach (var n in nums)
                if (dict.ContainsKey(n))
                    dict[n]++;
                else
                    dict[n] = 1;
            var res = 0;
            foreach (var kvp in dict)
                if (Take(kvp.Value) < MAX)
                    res += Take(kvp.Value);
                else
                    return -1;
            return res;

            int Take(int count)
            {
                if (count < 0)
                    return MAX;
                if (memo.ContainsKey(count))
                    return memo[count];
                var res = MAX;
                if (count % 3 == 0)
                    res = count / 3;
                else if (count == 2 || count == 3)
                    res = 1;
                else
                {
                    var v1 = Take(count - 3);
                    var v2 = Take(count - 2);
                    res = Math.Min(v1, v2) + 1;
                }

                memo[count] = res;
                return res;
            }
        }
    }
}
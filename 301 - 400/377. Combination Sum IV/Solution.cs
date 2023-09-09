using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace CombinationSumIV
{
    public class Solution
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var memo = new Dictionary<int, int>();

            return Count(target);

            int Count(int tgt)
            {
                if (memo.ContainsKey(tgt))
                    return memo[tgt];

                var res = 0;
                foreach (var n in nums)
                    if (n == tgt)
                        res++;
                    else if (n < tgt)
                        res += Count(tgt - n);
                memo[tgt] = res;
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FrogJump
{
    public class Solution
    {
        public bool CanCross(int[] stones)
        {
            var memo = new Dictionary<(int pos, int k), bool>();

            return Check(0, 0);

            bool Check(int pos, int k)
            {
                var key = (pos, k);
                if (pos == stones.Length - 1)
                    return true;
                if (memo.ContainsKey(key))
                    return memo[key];

                var res = false;
                for (int i = pos + 1; i < stones.Length && !res; i++)
                    if (stones[i] - stones[pos] >= k - 1 && stones[i] - stones[pos] <= k + 1)
                        res = Check(i, stones[i] - stones[pos]);
                    else if (stones[i] - stones[pos] > k + 1)
                        break;

                memo[key] = res;
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountWaysToBuildGoodStrings
{
    public class Solution
    {
        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            const int MOD = 1_000_000_007;
            var memo = new int?[high + 1];

            long res = 0;
            for (int i = low; i <= high; i++)
            {
                res += Check(i);
                res %= MOD;
            }

            return (int)res;

            int Check(int len)
            {
                if (memo[len].HasValue)
                    return memo[len].Value;
                var res = 0;
                if (len - zero >= 0)
                    res += (len - zero == 0 ? 1 : Check(len - zero));
                res %= MOD;
                if (len - one >= 0)
                    res += (len - one == 0 ? 1 : Check(len - one));
                res %= MOD;
                memo[len] = res;
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace IntegerBreak
{
    public class Solution
    {
        public int IntegerBreak(int n)
        {
            var memo = new int?[60];

            return Memo(n);

            int Memo(int val)
            {
                if (memo[val].HasValue)
                    return memo[val].Value;
                if (val < 3)
                    return 1;
                var res = 0;
                for (int i = 2; i < val; i++)
                    res = Math.Max(res, i * Math.Max(val - i, Memo(val - i)));
                memo[val] = res;
                return res;
            }
        }
    }
}
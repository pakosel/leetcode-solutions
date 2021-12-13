using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountNumberOfHomogenousSubstrings
{
    public class Solution
    {
        const int MOD = 1_000_000_007;
        public int CountHomogenous(string s)
        {
            var res = 0;
            var curr = s[0];
            var currLen = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == curr)
                    currLen++;
                else
                {
                    res += Sum(currLen);

                    curr = s[i];
                    currLen = 1;
                }
            }
            res += Sum(currLen);

            return res;
        }

        private int Sum(int currLen)
        {
            var res = 0;
            for (int j = 1; j <= currLen; j++)
            {
                res += j;
                res %= MOD;
            }
            return res;
        }
    }
}
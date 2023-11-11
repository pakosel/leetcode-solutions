using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountNumberOfHomogenousSubstrings
{
    public class Solution_2023
    {
        int[] memo = new int[100001];
        int MOD = 1_000_000_007;
        public int CountHomogenous(string s)
        {
            long res = 0;
            int left = 0, right = 0;
            while (right < s.Length)
            {
                if (right + 1 >= s.Length || s[right + 1] != s[left])
                {
                    res += Calc(right - left + 1);
                    res %= MOD;
                    right++;
                    left = right;
                }
                else
                    right++;
            }
            return (int)res;

            int Calc(int val)
            {
                if (memo[val] != 0)
                    return memo[val];
                if (val == 1)
                    return 1;
                var res = Calc(val - 1) + val;
                res %= MOD;
                memo[val] = res;
                return res;
            }
        }
    }

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
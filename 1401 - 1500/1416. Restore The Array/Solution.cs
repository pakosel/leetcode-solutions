using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RestoreTheArray
{
    public class Solution
    {
        public int NumberOfArrays(string s, int k)
        {
            var MOD = 1_000_000_007;
            var memo = new int?[s.Length];
            var len = k.ToString().Length;

            return Check(0);

            int Check(int start)
            {
                if (start == s.Length)
                    return 1;
                if (start > s.Length)
                    return 0;
                if (memo[start].HasValue)
                    return memo[start].Value;
                long res = 0;
                if (s[start] != '0')
                {
                    for (int i = 1; i < len; i++)
                    {
                        res += Check(start + i);
                        res %= MOD;
                    }
                    if (start + len <= s.Length && long.Parse(s[start..(start + len)]) <= k)
                    {
                        res += Check(start + len);
                        res %= MOD;
                    }
                }
                memo[start] = (int)res;
                return (int)res;
            }
        }
    }
}
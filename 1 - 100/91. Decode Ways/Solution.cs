using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DecodeWays
{
    public class Solution
    {
        public int NumDecodings(string s)
        {
            var dp = new int[s.Length];

            for(int i=0; i<s.Length; i++)
            {
                if(s[i] != '0')
                    dp[i] = (i == 0 ? 1 : dp[i-1]);
                var dblDigit = (i > 0 ? int.Parse(s.Substring(i-1, 2)) : 0);
                if(dblDigit > 9 && dblDigit < 27)
                    dp[i] += (i == 1 ? 1 : dp[i-2]);
            }
            return dp[s.Length-1];
        }
    }

    public class Solution_Memoization
    {
        public int NumDecodings(string s)
        {
            var memo = new Dictionary<int, int>();

            return Check(0);

            int Check(int pos)
            {
                if (pos >= s.Length)
                    return 0;
                if (memo.ContainsKey(pos))
                    return memo[pos];
                var res = 0;
                if (s[pos] == '0')
                    res = 0;
                else if (pos == s.Length - 1)
                    res = 1;
                else
                {
                    res += Check(pos + 1);
                    if (pos + 1 < s.Length && int.Parse(s.Substring(pos, 2)) < 27)
                        res += (pos + 2 < s.Length ? Check(pos + 2) : 1);
                }

                memo.Add(pos, res);
                return res;
            }
        }
    }
}
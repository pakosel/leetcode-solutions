using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestPalindromicSubsequence
{
    public class Solution
    {
        Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();

        public int LongestPalindromeSubseq(string s)
        {
            return Helper(s, (0, s.Length - 1));
        }

        private int Helper(string s, (int, int) range)
        {
            if (memo.ContainsKey(range))
                return memo[range];

            int res = 0;
            bool equals = s[range.Item1] == s[range.Item2];
            int dist = range.Item2 - range.Item1;

            if (dist == 0)
                res = 1;
            else if (dist == 1)
                res = equals ? 2 : 1;
            else
                res = equals ?
                        2 + Helper(s, (range.Item1 + 1, range.Item2 - 1)) :
                        Math.Max(Helper(s, (range.Item1, range.Item2 - 1)), Helper(s, (range.Item1 + 1, range.Item2)));

            memo.Add(range, res);
            return res;
        }
    }
}
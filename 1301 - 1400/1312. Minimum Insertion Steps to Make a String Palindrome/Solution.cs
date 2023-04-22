using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumInsertionStepsToMakeStringPalindrome
{
    public class Solution
    {
        public int MinInsertions(string s)
        {
            var memo = new int?[500, 500];

            return Check(0, s.Length - 1);

            int Check(int start, int end)
            {
                if (end - start <= 0)
                    return 0;
                if (memo[start, end].HasValue)
                    return memo[start, end].Value;
                var res = 0;
                if (s[start] == s[end])
                    res = Check(start + 1, end - 1);
                else
                    res = 1 + Math.Min(Check(start + 1, end), Check(start, end - 1));
                memo[start, end] = res;

                return res;
            }
        }
    }

    public class Solution_Ranges
    {
        public int MinInsertions(string s)
        {
            var memo = new Dictionary<string, int>();

            return Check(s);

            int Check(string str)
            {
                if (str.Length <= 1)
                    return 0;
                if (memo.ContainsKey(str))
                    return memo[str];
                var res = 0;
                if (str[0] == str[str.Length - 1])
                    res = Check(str[1..^1]);
                else
                    res = 1 + Math.Min(Check(str[1..]), Check(str[..^1]));
                memo[str] = res;

                return res;
            }
        }
    }
}
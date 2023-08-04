using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WordBreak
{
    public class Solution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var set = new HashSet<string>(wordDict);
            var memo = new bool?[s.Length];

            return Check(0);

            bool Check(int start)
            {
                if (start >= s.Length)
                    return true;
                if (memo[start].HasValue)
                    return memo[start].Value;
                var res = false;
                var sb = new StringBuilder();
                for (int i = start; i < s.Length; i++)
                {
                    sb.Append(s[i]);
                    if (set.Contains(sb.ToString()))
                        if (Check(i + 1))
                        {
                            res = true;
                            break;
                        }
                }
                memo[start] = res;
                return res;
            }
        }
    }
}
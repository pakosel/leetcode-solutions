using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DeleteOperationForTwoStrings
{
    public class Solution
    {
        Dictionary<(string, string), int> memo = new Dictionary<(string, string), int>();

        public int MinDistance(string word1, string word2)
        {
            return Helper(word1, word2);
        }

        private int Helper(string s1, string s2)
        {
            if (memo.ContainsKey((s1, s2)))
                return memo[(s1, s2)];
            else if (memo.ContainsKey((s2, s1)))
                return memo[(s2, s1)];
            
            int res;
            int len1 = s1.Length;
            int len2 = s2.Length;
            
            if (len1 == 0)
                res = len2;
            else if (len2 == 0)
                res = len1;
            else if (s1[0] == s2[0])
                res = Helper(s1.Substring(1), s2.Substring(1));
            else
            {
                int v1 = Helper(s1.Substring(1), s2);
                int v2 = Helper(s1, s2.Substring(1));
                res = 1 + Math.Min(v1, v2);
            }

            memo.Add((s1, s2), res);
            return res;
        }
    }
}
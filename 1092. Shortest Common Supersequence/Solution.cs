using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestCommonSubsequence
{
    public class Solution
    {
        Dictionary<(string, string), string> memo = new Dictionary<(string, string), string>();

        public string ShortestCommonSupersequence(string str1, string str2)
        {
            return FindMinSubseq(str1, str2);
        }

        private string FindMinSubseq(string s1, string s2)
        {
            if (memo.ContainsKey((s1, s2)))
                return memo[(s1, s2)];
            else if (memo.ContainsKey((s2, s1)))
                return memo[(s2, s1)];

            string val;
            if (s1.Length == 0)
                val = s2;
            else if (s2.Length == 0)
                val = s1;
            else if (s1[0] == s2[0])
                val = s1[0] + FindMinSubseq(s1.Substring(1), s2.Substring(1));
            else
            {
                string sub1 = FindMinSubseq(s1.Substring(1), s2);
                string sub2 = FindMinSubseq(s1, s2.Substring(1));
                val = sub1.Length < sub2.Length ? s1[0] + sub1 : s2[0] + sub2;
            }

            memo.Add((s1, s2), val);
            return val;
        }
    }
}
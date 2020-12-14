using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PalindromePartitioning
{
    public class Solution
    {
        Dictionary<string, List<IList<string>>> dict = new Dictionary<string, List<IList<string>>>();
        Dictionary<string, bool> palindromes = new Dictionary<string, bool>();

        public IList<IList<string>> Partition(string s)
        {
            return Helper(s);
        }

        private List<IList<string>> Helper(string s)
        {
            if (dict.ContainsKey(s))
                return dict[s];

            int len = s.Length;
            var res = new List<IList<string>>();
            if (IsPalindrome(s))
                res.Add(new List<string>() { s });

            for (int i = 1; i < len; i++)
            {
                var left = s.Substring(0, i);
                if (IsPalindrome(left))
                {
                    var right = s.Substring(i);
                    var list = Helper(right);
                    foreach (var l in list)
                    {
                        var n = new List<string>() { left };
                        n.AddRange(l);
                        res.Add(n);
                    }
                }
            }

            dict.Add(s, res);
            return res;
        }

        private bool IsPalindrome(string s)
        {
            if (palindromes.ContainsKey(s))
                return palindromes[s];

            int len = s.Length;
            bool res = true;
            if (len > 1)
            {
                int lp = 0;
                int rp = len - 1;
                while (lp < rp)
                {
                    if (s[lp++] != s[rp--])
                    {
                        res = false;
                        break;
                    }
                }
            }

            palindromes.Add(s, res);
            return res;
        }
    }
}
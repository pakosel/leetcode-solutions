using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PalindromePartitioning
{
    public class Solution2024
    {
        public IList<IList<string>> Partition(string s)
        {
            var memo = new Dictionary<(int, int), IList<IList<string>>>();

            return Memo(0, s.Length - 1);

            IList<IList<string>> Memo(int start, int end)
            {
                var key = (start, end);
                if (memo.ContainsKey(key))
                    return memo[key];
                var res = new List<IList<string>>();
                if (start == end)
                    res.Add(new List<string>() { s[start..(end + 1)] });
                else
                {
                    for (int i = start; i <= end; i++)
                        if (CheckPalindrome(start, i))
                        {
                            var sub = Memo(i + 1, end);
                            if (i + 1 > end)
                                res.Add(new List<string>() { s[start..(i + 1)] });
                            else
                                foreach (var list in sub)
                                {
                                    var n = new List<string>() { s[start..(i + 1)] };
                                    n.AddRange(list);
                                    res.Add(n);
                                }
                        }
                }
                memo[key] = res;
                return res;
            }

            bool CheckPalindrome(int start, int end)
            {
                while (start < end)
                    if (s[start++] != s[end--])
                        return false;
                return true;
            }
        }
    }

    public class Solution
    {
        Dictionary<string, List<IList<string>>> dict = new();
        Dictionary<string, bool> palindromes = new();

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
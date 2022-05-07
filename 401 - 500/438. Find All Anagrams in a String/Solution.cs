using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindAllAnagramsInString
{
    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var res = new List<int>();
            var pat = new int[26];
            foreach (var c in p)
                pat[c - 'a']++;
            var left = 0;
            var right = 0;
            var curr = new int[26];
            while (right < s.Length)
            {
                var c = s[right];
                curr[c - 'a']++;
                if (right - left + 1 == p.Length)
                {
                    if (curr.SequenceEqual(pat))
                        res.Add(left);

                    curr[s[left++] - 'a']--;
                }
                right++;
            }
            return res;
        }
    }
}
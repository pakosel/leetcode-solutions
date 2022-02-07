using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindTheDifference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                else
                    dict[c]++;
            foreach (var c in t)
                if (!dict.ContainsKey(c) || dict[c] == 0)
                    return c;
                else
                    dict[c]--;
            return t[0];
        }
    }
}
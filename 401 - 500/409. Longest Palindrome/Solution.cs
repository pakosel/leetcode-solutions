using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestPalindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c, 1);
            var gotOdd = false;
            var res = 0;
            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 == 1)
                    gotOdd = true;

                res += ((kvp.Value / 2) * 2);
            }

            if (gotOdd)
                res++;
            return res;
        }
    }
}
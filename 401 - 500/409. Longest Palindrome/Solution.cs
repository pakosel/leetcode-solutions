using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestPalindrome
{
    public class Solution2024
    {
        public int LongestPalindrome(string s)
        {
            var arr = new int[255];
            foreach (var c in s)
                arr[c]++;
            var res = 0;
            foreach (var e in arr)
                res += 2 * (e / 2);
            if (res % 2 == 0 && arr.Any(e => e % 2 == 1))
                res++;
            return res;
        }
    }
    
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
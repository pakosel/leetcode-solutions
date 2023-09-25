using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindTheDifference
{
    public class Solution_2023
    {
        public char FindTheDifference(string s, string t)
        {
            var letters = new int[26];
            foreach (var c in s)
                letters[c - 'a']++;
            foreach (var c in t)
                if (--letters[c - 'a'] < 0)
                    return c;
            return 'a';
        }
    }
    
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
using System.Collections.Generic;
using System.Linq;
using System;

namespace ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var arr = new int[26];
            foreach (var c in s)
                arr[c - 'a']++;
            foreach (var c in t)
                arr[c - 'a']--;

            return arr.All(e => e == 0);
        }
    }
}
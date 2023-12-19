using System.Collections.Generic;
using System.Linq;
using System;

namespace ValidAnagram
{
    public class Solution_2023
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var arr = new int[26];
            foreach (var c in s)
                arr[c - 'a']++;
            foreach (var c in t)
                if (arr[c - 'a'] < 1)
                    return false;
                else
                    arr[c - 'a']--;
            return true;
        }
    }
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
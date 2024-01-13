using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumNumberOfStepsToMakeTwoStringsAnagram
{
    public class Solution
    {
        public int MinSteps(string s, string t)
        {
            var len = s.Length;
            var arr = new int[26];
            for (int i = 0; i < len; i++)
                arr[s[i] - 'a']++;
            for (int i = 0; i < len; i++)
                if (arr[t[i] - 'a'] > 0)
                    arr[t[i] - 'a']--;

            return arr.Sum();
        }
    }

}
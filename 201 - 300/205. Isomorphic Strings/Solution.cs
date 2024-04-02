using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace IsomorphicStrings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var replaceS = new int[255];
            var replaceT = new int[255];
            for (int i = 0; i < s.Length; i++)
                if (replaceS[s[i]] == 0 && replaceT[t[i]] == 0)
                {
                    replaceS[s[i]] = t[i];
                    replaceT[t[i]] = s[i];
                }
                else if (replaceS[s[i]] != t[i] || replaceT[t[i]] != s[i])
                    return false;
            return true;
        }
    }
}
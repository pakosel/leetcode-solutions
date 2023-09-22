using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace IsSubsequence
{
    public class Solution_2023
    {
        public bool IsSubsequence(string s, string t)
        {
            int si = 0, ti = 0;

            while (si < s.Length && ti < t.Length)
            {
                if (s[si] == t[ti])
                    si++;
                ti++;
            }
            return si == s.Length;
        }
    }
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int sIdx = 0;
            int tIdx = 0;

            while (sIdx < s.Length && tIdx < t.Length)
            {
                if (s[sIdx] == t[tIdx])
                    sIdx++;
                tIdx++;
            }

            return sIdx == s.Length;
        }
    }
}
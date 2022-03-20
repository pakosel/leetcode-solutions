using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximizeNumberOfSubsequencesInString
{
    public class Solution
    {
        public long MaximumSubsequenceCount(string text, string pattern)
        {
            var same = (pattern[0] == pattern[1]);
            long res = 0;
            long first = 0;
            long sec = 0;
            foreach (var c in text)
                if (c == pattern[0])
                {
                    if (same)
                        res += first;
                    first++;
                }
                else if (c == pattern[1])
                {
                    res += first;
                    sec++;
                }
            if (same)
                res += first;
            else
                res += Math.Max(first, sec);

            return res;
        }
    }
}
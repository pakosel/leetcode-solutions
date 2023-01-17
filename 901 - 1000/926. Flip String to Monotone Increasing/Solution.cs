using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FlipStringToMonotoneIncreasing
{
    public class Solution
    {
        public int MinFlipsMonoIncr(string s)
        {
            var n = s.Length;
            var allZero = new int[n];
            var allOnes = new int[n];
            allZero[0] = s[0] == '0' ? 0 : 1;
            allOnes[n - 1] = s[n - 1] == '1' ? 0 : 1;

            for (int i = 1; i < n; i++)
                allZero[i] = allZero[i - 1] + (s[i] == '0' ? 0 : 1);
            for (int i = n - 2; i >= 0; i--)
                allOnes[i] = allOnes[i + 1] + (s[i] == '1' ? 0 : 1);
            var res = Math.Min(allZero[n - 1], allOnes[0]);
            for (int i = 0; i < n - 1; i++)
                res = Math.Min(res, allZero[i] + allOnes[i + 1]);

            return res;
        }
    }
}
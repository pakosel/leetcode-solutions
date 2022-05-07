using System.Collections.Generic;
using System.Linq;
using System;

namespace MinimumAsciiDeleteSumForTwoStrings
{
    public class Solution
    {
        public int MinimumDeleteSum(string s1, string s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;

            int[,] arr = new int[len1 + 1, len2 + 1];
            for (int i = 0; i < len1; i++)
                arr[i + 1, 0] = arr[i, 0] + s1[i];
            for (int j = 0; j < len2; j++)
                arr[0, j + 1] = arr[0, j] + s2[j];

            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                    arr[i + 1, j + 1] = s1[i] == s2[j] ? arr[i, j] : Math.Min(arr[i, j + 1] + s1[i], arr[i + 1, j] + s2[j]);

            return arr[len1, len2];
        }
    }
}
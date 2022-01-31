using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindSubstringWithGivenHashValue
{
    public class Solution
    {
        public string SubStrHash(string s, int power, int m, int k, int hashValue)
        {
            var arr = new int[s.Length];
            var powers = new long[k];
            powers[0] = 1;
            for (int i = 1; i < k; i++)
                powers[i] = (powers[i - 1] * power) % m;

            for (int i = 0; i < s.Length; i++)
                arr[i] = s[i] - 'a' + 1;

            for (int i = 0; i < s.Length && i + k - 1 < s.Length; i++)
            {
                long val = arr[i] % m;
                for (int j = 1; j < k; j++)
                    val = (val + arr[i + j] * powers[j]) % m;

                if (val == hashValue)
                    return s.Substring(i, k);
            }

            return s.Substring(0, k);
        }
    }
}
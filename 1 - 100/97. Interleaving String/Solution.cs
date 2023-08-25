using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace InterleavingString
{
    public class Solution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
                return false;

            var memo = new bool?[s1.Length + 1, s2.Length + 1, s3.Length + 1];

            return Check(0, 0, 0);

            bool Check(int i1, int i2, int i3)
            {
                if (i1 >= s1.Length && i2 >= s2.Length)
                    return i3 >= s3.Length;
                if (memo[i1, i2, i3].HasValue)
                    return memo[i1, i2, i3].Value;

                var res = false;

                if (i1 < s1.Length && s1[i1] == s3[i3])
                    res = Check(i1 + 1, i2, i3 + 1);

                if (!res && i2 < s2.Length && s2[i2] == s3[i3])
                    res = Check(i1, i2 + 1, i3 + 1);

                memo[i1, i2, i3] = res;
                return res;
            }
        }
    }
}
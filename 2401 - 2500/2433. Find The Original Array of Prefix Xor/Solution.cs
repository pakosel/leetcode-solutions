using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheOriginalArrayOfPrefixXor
{
    public class Solution
    {
        public int[] FindArray(int[] pref)
        {
            var len = pref.Length;
            var res = new int[len];
            var xor = 0;
            for (int i = 0; i < len; i++)
            {
                res[i] = pref[i];
                if (i > 0)
                    xor ^= res[i - 1];
                res[i] ^= xor;
            }
            return res;
        }
    }
}
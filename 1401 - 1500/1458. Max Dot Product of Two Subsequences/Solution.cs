using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaxDotProductOfTwoSubsequences
{
    public class Solution
    {
        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            var memo = new Dictionary<(int, int), int>();

            return Memo(0, 0);

            int Memo(int i1, int i2)
            {
                var key = (i1, i2);
                if (memo.ContainsKey(key))
                    return memo[key];
                var res = nums1[i1] * nums2[i2];
                if (i1 + 1 < nums1.Length && i2 + 1 < nums2.Length)
                    res += Math.Max(0, Memo(i1 + 1, i2 + 1));
                if (i1 + 1 < nums1.Length)
                    res = Math.Max(res, Memo(i1 + 1, i2));
                if (i2 + 1 < nums2.Length)
                    res = Math.Max(res, Memo(i1, i2 + 1));
                memo[key] = res;
                return res;
            }
        }
    }
}
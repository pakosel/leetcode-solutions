using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace UncrossedLines
{
    public class Solution
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            var memo = new int?[nums1.Length, nums2.Length];

            return Check(0, 0);

            int Check(int i1, int i2)
            {
                if (i1 >= nums1.Length || i2 >= nums2.Length)
                    return 0;

                if (memo[i1, i2].HasValue)
                    return memo[i1, i2].Value;
                int i = i1, j = i2, res = 0;

                for (i = i1; i < nums1.Length && res == 0; i++)
                    for (j = i2; j < nums2.Length && res == 0; j++)
                        if (nums1[i] == nums2[j])
                            res = 1 + Check(i+1, j+1);
                
                if(res > 0) //otherwise no matching index was found so no need to check
                    res = Math.Max(res, Check(i1 + 1, i2));

                memo[i1, i2] = res;

                return res;
            }
        }
    }
}
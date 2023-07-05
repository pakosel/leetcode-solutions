using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestSubarrayOf1sAfterDeletingOneElement
{
    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            var res = 0;
            var prev = 0;
            var curr = 0;
            bool hadZero = false;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == 1)
                    curr++;
                else
                {
                    hadZero = true;
                    if (curr > 0)
                        Check(i);
                }

            Check(nums.Length);
            return res;

            void Check(int i)
            {
                if (prev > 0)
                    res = Math.Max(res, curr + prev);
                else
                    res = Math.Max(res, hadZero ? curr : curr - 1);
                if (i + 1 < nums.Length && nums[i + 1] == 1)
                    prev = curr;
                else
                    prev = 0;
                curr = 0;
            }
        }
    }
}
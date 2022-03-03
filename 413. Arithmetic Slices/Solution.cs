using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ArithmeticSlices
{
    public class Solution
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            var res = 0;
            for (int i = 0; i < nums.Length - 2; i++)
                res += Check(nums, i);
            return res;
        }

        private int Check(int[] nums, int start)
        {
            var res = 0;
            if (nums.Length - start < 3)
                return res;
            var diff = nums[start] - nums[start + 1];
            for (int i = start + 1; i < nums.Length - 1; i++)
                if (nums[i] - nums[i + 1] != diff)
                    return res;
                else
                    res++;
            return res;
        }
    }
}
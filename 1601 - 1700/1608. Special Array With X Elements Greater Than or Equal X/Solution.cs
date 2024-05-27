using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SpecialArrayWithXelementsGreaterThanOrEqualX
{
    public class Solution
    {
        public int SpecialArray(int[] nums)
        {
            var len = nums.Length;
            Array.Sort(nums);

            for (int x = 1; x <= len; x++)
                if (Check(x) == x)
                    return x;

            return -1;

            int Check(int num)
            {
                for (int i = 0; i < len; i++)
                    if (nums[i] >= num)
                        return len - i;
                return 0;
            }
        }
    }
}
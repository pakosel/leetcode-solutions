using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            long all = 1;
            var zindex = -1;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != 0)
                    all *= nums[i];
                else if (zindex == -1)
                    zindex = i;
                else
                    zindex = nums.Length;
            if (zindex == nums.Length)
                Array.Fill(nums, 0);
            else if (zindex != -1)
            {
                Array.Fill(nums, 0);
                nums[zindex] = (int)all;
            }
            else
                for (int i = 0; i < nums.Length; i++)
                    nums[i] = (int)(all / nums[i]);
            return nums;
        }
    }
}
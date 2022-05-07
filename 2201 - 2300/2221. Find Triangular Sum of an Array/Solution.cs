using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTriangularSumOfAnArray
{
    public class Solution
    {
        public int TriangularSum(int[] nums)
        {
            if (nums.Length == 1 || nums[1] == -1)
                return nums[0];
            var last = nums.Length - 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] == -1)
                {
                    last = i;
                    break;
                }
                nums[i] = (nums[i] + nums[i + 1]) % 10;
            }
            nums[last] = -1;

            return TriangularSum(nums);
        }
    }
}
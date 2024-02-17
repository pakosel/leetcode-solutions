using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindPolygonWithTheLargestPerimeter
{
    public class Solution
    {
        public long LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            long res = -1;
            long sum = nums[0] + nums[1];
            for (int i = 2; i < nums.Length; i++)
            {
                if (sum > nums[i])
                    res = sum + nums[i];
                sum += nums[i];
            }
            return res;
        }
    }
}
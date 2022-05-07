using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SumOfBeautyInTheArray
{
    public class Solution
    {
        public int SumOfBeauties(int[] nums)
        {
            var len = nums.Length;
            var okLeft = new bool[len];
            var res = 0;
            var min = nums[0];
            var max = nums[len - 1];

            for (int i = 1; i < len - 1; i++)
            {
                if (nums[i - 1] < nums[i] && nums[i] < nums[i + 1])
                    res++;
                if (nums[i] > min)
                    okLeft[i] = true;
                min = Math.Max(min, nums[i]);
            }

            for (int i = len - 2; i > 0; i--)
            {
                if (okLeft[i] && nums[i] < max)
                    res++;
                max = Math.Min(max, nums[i]);
            }

            return res;
        }
    }
}
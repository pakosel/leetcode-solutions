using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DivideArrayIntoArraysWithMaxDifference
{
    public class Solution
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            var n = nums.Length;
            var res = new List<int[]>();
            Array.Sort(nums);
            int i = 0;
            while (i < n)
            {
                if (nums[i + 2] - nums[i] > k)
                    return new int[0][];
                else
                    res.Add(new int[] { nums[i], nums[i + 1], nums[i + 2] });
                i += 3;
            }
            return res.ToArray();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BinarySearch
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] == target)
                    return mid;
                if (target > nums[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SearchInRotatedSortedArrayII
{
    public class Solution
    {
        public bool Search(int[] nums, int target)
        {
            if (nums[0] == target)
                return true;
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] == target)
                    return true;
                else if (nums[i] < nums[i - 1])
                    return BinSearch(nums, target, i, nums.Length - 1);

            return false;
        }

        private bool BinSearch(int[] nums, int target, int start, int end)
        {
            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (target == nums[mid])
                    return true;
                if (target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return false;
        }
    }
}
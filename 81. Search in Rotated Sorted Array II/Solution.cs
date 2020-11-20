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
            if (nums.Length == 0)
                return false;

            var res = SearchForward(nums, target);
            if (res == null)
                res = SearchBackward(nums, target);

            return res == true ? true : false;
        }

        private bool? SearchForward(int[] nums, int target)
        {
            int i = 0;
            int prev = nums[i];
            while (i < nums.Length && nums[i] < target)
            {
                if (nums[i] < prev)
                    return null;
                prev = nums[i++];
            }
            if (i == 0 && nums[i] != target)
                return null;

            return i < nums.Length && nums[i] == target;
        }

        private bool? SearchBackward(int[] nums, int target)
        {
            int len = nums.Length;
            int i = len - 1;
            int prev = nums[i];
            while (i >= 0 && nums[i] > target)
            {
                if (nums[i] > prev)
                    return false;
                prev = nums[i--];
            }

            return i >= 0 && nums[i] == target;
        }
    }
}
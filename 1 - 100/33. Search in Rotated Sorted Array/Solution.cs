using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SearchInRotatedSortedArray
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int idx;
            var res = SearchForward(nums, target, out idx);
            if (res == null)
                res = SearchBackward(nums, target, out idx);

            return res == true ? idx : -1;
        }

        private bool? SearchForward(int[] nums, int target, out int i)
        {
            i = 0;
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

        private bool? SearchBackward(int[] nums, int target, out int i)
        {
            int len = nums.Length;
            i = len - 1;
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
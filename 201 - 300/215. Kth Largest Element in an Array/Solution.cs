using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KthLargestElementInAnArray
{
    public class Solution2022
    {
        public int FindKthLargest(int[] nums, int k) => nums.OrderByDescending(_ => _).Skip(k-1).First();
    }

    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }
}
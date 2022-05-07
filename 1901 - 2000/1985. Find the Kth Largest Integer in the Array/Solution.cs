using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheKthLargestIntegerInTheArray
{
    public class Solution
    {
        public string KthLargestNumber(string[] nums, int k)
        {
            Array.Sort(nums, (s1, s2) => s1.Length != s2.Length ? s1.Length.CompareTo(s2.Length) : s1.CompareTo(s2));
            return nums[nums.Length - k];
        }
    }
}
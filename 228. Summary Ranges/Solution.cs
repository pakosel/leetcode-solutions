using System.Collections.Generic;
using System.Linq;
using System;

namespace SummaryRanges
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var res = new List<string>();
            if (nums.Length == 0)
                return res;
            var left = 0;
            var right = 0;
            var curr = 0;
            while (++curr < nums.Length)
                if ((long)nums[curr] - (long)nums[right] > 1)
                {
                    res.Add(Print(nums, left, right));
                    left = curr;
                    right = curr;
                }
                else
                    right = curr;
            res.Add(Print(nums, left, right));

            return res;
        }

        private string Print(int[] nums, int x, int y) => (x == y) ? $"{nums[x]}" : $"{nums[x]}->{nums[y]}";
    }
}
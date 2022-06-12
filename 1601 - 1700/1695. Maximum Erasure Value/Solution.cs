using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumErasureValue
{
    public class Solution
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            var set = new HashSet<int>();
            int max = 0, sum = 0, left = 0, right = -1;
            while (++right < nums.Length)
            {
                while (set.Contains(nums[right]))
                {
                    sum -= nums[left];
                    set.Remove(nums[left++]);
                }

                sum += nums[right];
                set.Add(nums[right]);
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
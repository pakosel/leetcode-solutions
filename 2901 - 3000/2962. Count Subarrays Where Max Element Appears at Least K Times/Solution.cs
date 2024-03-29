using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    public class Solution
    {
        public long CountSubarrays(int[] nums, int k)
        {
            int max = nums.Max();
            long res = 0;
            int left = 0, right = 0, curr = 0;

            while (right < nums.Length)
            {
                if (nums[right] == max)
                    curr++;

                while (curr >= k)
                {
                    res += nums.Length - right;
                    if (nums[left++] == max)
                        curr--;
                }

                right++;
            }

            return res;
        }
    }
}
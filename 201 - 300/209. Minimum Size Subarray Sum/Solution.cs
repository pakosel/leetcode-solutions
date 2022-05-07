using System.Collections.Generic;
using System.Linq;
using System;

namespace MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int len = nums.Length;
            if(len == 0)
                return 0;

            int left = 0;
            int right = 0;
            int min = int.MaxValue;
            int sum = nums[0];

            while(left < len)
            {
                if(sum >= s)
                {
                    int dist = right - left + 1;
                    min = Math.Min(dist, min);
                    if(left == right)
                        break;
                    sum -= nums[left++];
                }
                else if(right + 1 < len)
                    sum += nums[++right];
                else
                    break;
            }

            return min == int.MaxValue ? 0 : min;
        }
    }
}
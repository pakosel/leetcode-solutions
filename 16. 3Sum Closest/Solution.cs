using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreeSumClosest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int res = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                var start = i + 1;
                var end = nums.Length - 1;
                var lookingFor = target - nums[i];

                while (start < end)
                {
                    var currSum = nums[i] + nums[start] + nums[end];

                    if (Math.Abs(currSum - target) < Math.Abs(res - target))
                        res = currSum;
                    if (nums[start] + nums[end] < lookingFor)
                        start++;
                    else if (nums[start] + nums[end] > lookingFor)
                        end--;
                    else
                        return res;
                }
            }

            return res;
        }
    }
}
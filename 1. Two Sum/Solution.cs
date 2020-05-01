using System.Collections.Generic;
using System.Linq;
using System;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            Dictionary<int, int> visited = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                var lookingFor = target - nums[i];
                if (visited.ContainsKey(lookingFor))
                    return new int[] { visited[lookingFor], i };
                else
                    if (!visited.ContainsKey(nums[i]))
                    visited.Add(nums[i], i);
            }
            return new int[0];
        }
    }
}
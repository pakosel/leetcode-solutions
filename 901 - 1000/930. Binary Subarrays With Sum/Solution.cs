using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BinarySubarraysWithSum
{
    public class Solution
    {
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            var res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var prev = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    prev += nums[j];
                    if (prev == goal)
                        res++;
                }
            }
            return res;
        }
    }
}
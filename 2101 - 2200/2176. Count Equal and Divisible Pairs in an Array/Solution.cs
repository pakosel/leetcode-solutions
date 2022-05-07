using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountEqualAndDivisiblePairsInAnArray
{
    public class Solution
    {
        public int CountPairs(int[] nums, int k)
        {
            var res = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if ((i * j) % k == 0 && nums[i] == nums[j])
                        res++;
            return res;
        }
    }
}
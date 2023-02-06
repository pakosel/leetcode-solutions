using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ShuffleTheArray
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var res = new int[2 * n];
            var idx = 0;
            for (int i = 0, j = n; i < n; i++, j++)
            {
                res[idx++] = nums[i];
                res[idx++] = nums[j];
            }
            return res;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReplaceElementsInAnArray
{
    public class Solution
    {
        public int[] ArrayChange(int[] nums, int[][] operations)
        {
            var positions = new int[1_000_001];
            for (int i = 0; i < nums.Length; i++)
                positions[nums[i]] = i;
            foreach (var op in operations)
            {
                var pos = positions[op[0]];
                nums[pos] = op[1];
                positions[op[0]] = 0;
                positions[op[1]] = pos;
            }
            return nums;
        }
    }
}
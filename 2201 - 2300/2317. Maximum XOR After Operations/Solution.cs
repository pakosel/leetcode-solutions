using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumXORAfterOperations
{
    public class Solution
    {
        public int MaximumXOR(int[] nums)
        {
            var or = 0;
            for (int i = 0; i < nums.Length; i++)
                or |= nums[i];

            return or;
        }
    }
}
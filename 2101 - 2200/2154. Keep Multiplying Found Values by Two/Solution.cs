using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace KeepMultiplyingFoundValuesByTwo
{
    public class Solution
    {
        public int FindFinalValue(int[] nums, int original)
        {
            while (nums.Contains(original))
                original *= 2;
            return original;
        }
    }
}
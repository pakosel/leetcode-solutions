using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LargestPositiveIntegerThatExistsWithItsNegative
{
    public class Solution
    {
        public int FindMaxK(int[] nums)
        {
            var set = new HashSet<int>();
            var res = -1;
            foreach (var n in nums)
            {
                set.Add(n);
                if (Math.Abs(n) > res && set.Contains(n) && set.Contains(-n))
                    res = Math.Abs(n);
            }
            return res;
        }
    }
}
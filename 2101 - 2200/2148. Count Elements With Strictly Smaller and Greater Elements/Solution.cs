using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountElementsWithStrictlySmallerAndGreaterElements
{
    public class Solution
    {
        public int CountElements(int[] nums)
        {
            var min = nums.Min();
            var max = nums.Max();
            return nums.Where(n => n > min && n < max).Count();
        }
    }
}
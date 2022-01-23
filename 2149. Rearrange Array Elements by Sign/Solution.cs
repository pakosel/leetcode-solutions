using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RearrangeArrayElementsBySign
{
    public class Solution
    {
        public int[] RearrangeArray(int[] nums)
        {
            var positive = nums.Where(n => n > 0);
            var negative = nums.Where(n => n < 0);

            return positive.Zip(negative, (p, n) => new int[] {p, n}).SelectMany(e => e).ToArray();
        }
    }
}
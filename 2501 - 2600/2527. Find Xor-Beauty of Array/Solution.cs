using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindXorBeautyOfArray
{
    public class Solution
    {
        public int XorBeauty(int[] nums)
        {
            var res = 0;
            foreach (var n in nums)
                res ^= n;
            return res;
        }
    }
}
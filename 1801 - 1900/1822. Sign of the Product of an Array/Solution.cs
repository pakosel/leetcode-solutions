using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SignOfTheProductOfAnArray
{
    public class Solution
    {
        public int ArraySign(int[] nums) =>
            nums.Count(n => n == 0) > 0 ? 0 :
            nums.Count(n => n < 0) % 2 == 1 ? -1 : 1;
    }
}
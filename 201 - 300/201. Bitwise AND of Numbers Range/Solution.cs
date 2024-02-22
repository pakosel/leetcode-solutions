using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BitwiseAndOfNumbersRange
{
    public class Solution
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            long res = left;
            for (long i = left; i <= right && res > 0; i++)
                res &= i;
            return res > int.MaxValue ? int.MaxValue - 1 : (int)res;
        }
    }
}
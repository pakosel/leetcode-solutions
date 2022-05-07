using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberAfterDoubleReversal
{
    public class Solution
    {
        public bool IsSameAfterReversals(int num)
        {
            if (num == 0)
                return true;
            return !num.ToString().EndsWith('0');
        }
    }
}
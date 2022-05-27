using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfStepsToReduceNumberToZero
{
    public class Solution
    {
        public int NumberOfSteps(int num)
        {
            var res = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                    num ^= 1;
                else
                    num >>= 1;
                res++;
            }
            return res;
        }
    }
}
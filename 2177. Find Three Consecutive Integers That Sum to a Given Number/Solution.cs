using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindThreeConsecutiveIntegersThatSumToGivenNumber
{
    public class Solution
    {
        public long[] SumOfThree(long num)
        {
            long div = num / 3;

            if (3 * div == num)
                return new long[3] { div - 1, div, div + 1 };

            return new long[0];
        }
    }
}
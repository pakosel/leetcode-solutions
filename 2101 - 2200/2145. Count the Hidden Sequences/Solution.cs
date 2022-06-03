using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountTheHiddenSequences
{
    public class Solution
    {
        public int NumberOfArrays(int[] differences, int lower, int upper)
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            var sumDiff = 0;
            foreach (var d in differences)
            {
                sumDiff += d;
                min = Math.Min(min, sumDiff);
                max = Math.Max(max, sumDiff);
            }

            var lowestPossibleNum = Math.Max(lower, lower + max);
            var highestPossibleNum = Math.Min(upper, upper + min);

            if (highestPossibleNum < lowestPossibleNum)
                return 0;

            return highestPossibleNum - lowestPossibleNum + 1;
        }
    }
}
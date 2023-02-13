using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountOddNumbersInAnIntervalRange
{
    public class Solution
    {
        public int CountOdds(int low, int high) =>
            low % 2 == 0 && high % 2 == 0 ? (high - low) / 2 : (high - low) / 2 + 1;
    }
}
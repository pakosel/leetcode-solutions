using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PartitioningIntoMinimumNumberOfDeciBinaryNumbers
{
    public class Solution
    {
        public int MinPartitions(string s)
        {
            int max = 0;
            foreach (var c in s)
            {
                max = Math.Max(c - '0', max);
                if (max == 9)
                    break;
            }
            return max;
        }
    }
}
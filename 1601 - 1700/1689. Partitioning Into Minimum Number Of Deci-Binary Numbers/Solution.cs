using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PartitioningIntoMinimumNumberOfDeciBinaryNumbers
{
    public class Solution2022
    {
        public int MinPartitions(string s)
        {
            int i;
            for (i = 9; i >= 0; i--)
                if (s.IndexOf((char)(i + '0')) != -1)
                    break;
            return i;
        }
    }
    
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
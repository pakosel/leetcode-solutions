using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SumOfSquareNumbers
{
    public class Solution
    {
        public bool JudgeSquareSum(int c)
        {
            var set = new HashSet<int>();
            var max = Math.Min(Math.Sqrt(int.MaxValue), Math.Sqrt(c));
            for (int i = 0; i <= max; i++)
            {
                var val = i * i;
                set.Add(val);
                if (set.Contains(c - val))
                    return true;
            }
            return false;
        }
    }
}
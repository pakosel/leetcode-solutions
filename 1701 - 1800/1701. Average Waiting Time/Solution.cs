using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AverageWaitingTime
{
    public class Solution
    {
        public double AverageWaitingTime(int[][] customers)
        {
            long res = 0;
            long curr = 1;
            foreach (var c in customers)
            {
                var wait = curr > c[0] ? curr - c[0] : 0;
                var prepare = c[1] + wait;
                res += prepare;
                curr = Math.Max(curr, c[0]) + c[1];
            }
            return (double)res / customers.Length;
        }
    }
}
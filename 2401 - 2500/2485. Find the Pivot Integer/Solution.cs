using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindThePivotInteger
{
    public class Solution
    {
        public int PivotInteger(int n)
        {
            var sumLeft = 1;
            var sumRight = n * (n + 1) / 2;
            int i = 1;
            while (sumLeft < sumRight)
            {
                sumRight -= i;
                i++;
                sumLeft += i;
            }
            if (sumLeft == sumRight)
                return i;
            return -1;
        }
    }
}
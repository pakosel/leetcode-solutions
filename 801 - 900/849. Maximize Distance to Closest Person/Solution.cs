using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximizeDistanceToClosestPerson
{
    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            var max = 0;
            var left = 0;
            for (int i = 0; i < seats.Length; i++)
                if (seats[i] == 1)
                {
                    max = left == 0 && seats[0] == 0 ? i : Math.Max(max, (i - left) / 2);
                    left = i;
                }
            max = Math.Max(max, seats.Length - 1 - left);
            return max;
        }
    }
}
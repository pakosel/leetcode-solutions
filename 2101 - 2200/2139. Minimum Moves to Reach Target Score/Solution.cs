using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumMovesToReachTargetScore
{
    public class Solution
    {
        public int MinMoves(int target, int maxDoubles)
        {
            var ops = 0;
            while (target > 1 && maxDoubles > 0)
            {
                if (target % 2 == 0)
                {
                    target = target / 2;
                    maxDoubles--;
                }
                else
                    target--;
                ops++;
            }
            if (target > 1)
                ops += (target - 1);
            return ops;
        }
    }
}
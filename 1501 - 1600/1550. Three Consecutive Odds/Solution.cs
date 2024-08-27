using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ThreeConsecutiveOdds
{
    public class Solution
    {
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            var odds = 0;
            foreach (var e in arr)
                if (e % 2 == 1)
                {
                    if (++odds == 3)
                        return true;
                }
                else
                    odds = 0;
            return false;
        }
    }
}
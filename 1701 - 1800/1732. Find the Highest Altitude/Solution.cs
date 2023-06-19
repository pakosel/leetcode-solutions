using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheHighestAltitude
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            var res = 0;
            var curr = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                curr += gain[i];
                res = Math.Max(res, curr);
            }
            return res;
        }
    }
}
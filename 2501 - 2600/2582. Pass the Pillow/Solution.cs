using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PassThePillow
{
    public class Solution
    {
        public int PassThePillow(int n, int time)
        {
            var trips = n - 1;
            var div = time / trips;
            var mod = time % trips;

            if (div % 2 == 0)
                return mod + 1;
            else
                return n - mod;
        }
    }
}
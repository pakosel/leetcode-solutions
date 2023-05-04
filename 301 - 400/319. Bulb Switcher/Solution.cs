using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BulbSwitcher
{
    public class Solution
    {
        public int BulbSwitch(int n)
        {
            if (n == 0)
                return 0;
            var sum = 3;
            var factor = 3;
            var i = 1;
            while (sum < n)
            {
                factor += 2;
                sum += factor;
                i++;
            }
            return i;
        }
    }
}
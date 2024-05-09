using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximizeHappinessOfSelectedChildren
{
    public class Solution
    {
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness);
            int idx = happiness.Length - 1, round = 0;
            long res = 0;
            while (idx >= 0 && k-- > 0)
                res += Math.Max(0, happiness[idx--] - round++);
            return res;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;

namespace ReducingDishes
{
    public class Solution
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            var lastNeg = -1;
            for (int i = 0; i < satisfaction.Length; i++)
                if (satisfaction[i] < 0)
                    lastNeg = i;
                else
                    break;

            if (lastNeg == satisfaction.Length - 1)
                return 0;
            var res = Sum(lastNeg + 1);

            for (int i = lastNeg; i >= 0; i--)
            {
                var candidate = Sum(i);
                if (candidate >= res)
                    res = candidate;
                else
                    break;
            }

            return res;

            int Sum(int start)
            {
                var res = 0;
                var cnt = 1;
                for (int i = start; i < satisfaction.Length; i++, cnt++)
                    res += cnt * satisfaction[i];
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumSplitOfPositiveEvenIntegers
{
    public class Solution
    {

        public IList<long> MaximumEvenSplit(long finalSum)
        {
            var res = new HashSet<long>();
            if (finalSum % 2 == 1)
                return res.ToList();
            Helper(finalSum, res, 2);
            return res.ToList();
        }

        private bool Helper(long tgt, HashSet<long> res, long start)
        {
            for (long i = start; i < tgt; i += 2)
                if (!res.Contains(i))
                {
                    res.Add(i);
                    if (Helper(tgt - i, res, i))
                        return true;
                    res.Remove(i);
                }
            if (!res.Contains(tgt))
            {
                res.Add(tgt);
                return true;
            }
            return false;
        }
    }
}
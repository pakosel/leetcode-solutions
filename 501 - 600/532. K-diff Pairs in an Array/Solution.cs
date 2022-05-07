using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KdiffPairsInAnArray
{
    public class Solution
    {
        public int FindPairs(int[] nums, int k)
        {
            var set = new HashSet<int>();
            var dbl = new HashSet<int>();
            var res = 0;
            foreach (var n in nums)
            {
                if (set.Contains(n))
                {
                    if (k == 0 && !dbl.Contains(n))
                    {
                        dbl.Add(n);
                        res++;
                    }
                }
                else
                {
                    if (set.Contains(n - k))
                        res++;
                    if (set.Contains(n + k))
                        res++;
                    set.Add(n);
                }
            }
            return res;
        }
    }
}
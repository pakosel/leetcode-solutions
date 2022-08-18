using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ReduceArraySizeToTheHalf
{
    public class Solution
    {
        public int MinSetSize(int[] arr)
        {
            var occ = arr.GroupBy(_ => _).Select((e, idx) => e.Count()).OrderByDescending(_ => _);
            var tgt = arr.Length / 2;
            var res = 0;
            foreach (var cnt in occ)
            {
                res++;
                tgt -= cnt;
                if (tgt <= 0)
                    break;
            }
            return res;
        }
    }
}
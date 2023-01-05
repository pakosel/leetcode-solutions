using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DeleteColumnsToMakeSorted
{
    public class Solution
    {
        public int MinDeletionSize(string[] strs)
        {
            var n = strs.Length;
            var res = 0;
            for (int i = 0; i < strs[0].Length; i++)
                for (int r = 1; r < n; r++)
                    if (strs[r][i] < strs[r - 1][i])
                    {
                        res++;
                        break;
                    }
            return res;
        }
    }
}
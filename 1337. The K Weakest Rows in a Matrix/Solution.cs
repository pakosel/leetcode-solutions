using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TheKWeakestRowsInMatrix
{
    public class Solution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            return mat.Select((row, index) => (index, row))
                        .OrderBy(x => x.row.Count(e => e == 1))
                        .ThenBy(x => x.index)
                        .Take(k)
                        .Select(x => x.index).ToArray();
        }
    }
}
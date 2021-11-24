using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace IntervalListIntersections
{
    public class Solution
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            var res = new List<int[]>();
            int idx1 = 0, idx2 = 0;
            while (idx1 < firstList.Length && idx2 < secondList.Length)
            {
                var start = Math.Max(firstList[idx1][0], secondList[idx2][0]);
                var end = Math.Min(firstList[idx1][1], secondList[idx2][1]);
                if (start <= end)
                    res.Add(new int[] { start, end });

                if (firstList[idx1][1] < secondList[idx2][1])
                    idx1++;
                else
                    idx2++;
            }
            return res.ToArray();
        }
    }
}
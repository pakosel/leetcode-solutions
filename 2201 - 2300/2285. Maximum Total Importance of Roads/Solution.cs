using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumTotalImportanceOfRoads
{
    public class Solution
    {
        public long MaximumImportance(int n, int[][] roads)
        {
            var arr = new (int city, int roads)[n];
            for (int i = 0; i < n; i++)
                arr[i] = (i, 0);
            foreach (var r in roads)
            {
                arr[r[0]].roads++;
                arr[r[1]].roads++;
            }
            Array.Sort(arr, (e1, e2) => e2.roads.CompareTo(e1.roads));

            var imp = n;
            var nodeNums = new int[n];
            foreach (var e in arr)
                nodeNums[e.city] = imp--;

            long res = 0;

            foreach (var r in roads)
                res += (nodeNums[r[0]] + nodeNums[r[1]]);

            return res;
        }
    }
}
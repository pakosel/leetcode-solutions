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
            foreach((int src, int tgt) r in roads.Select(r => (r[0], r[1])))
            {
                arr[r.src].roads++;
                arr[r.tgt].roads++;
            }
            //sort cities descending by roads count
            Array.Sort(arr, (e1, e2) => e2.roads.CompareTo(e1.roads));

            var nodeNums = new int[n];
            //assign values to nodes
            foreach (var e in arr)
                nodeNums[e.city] = n--;

            long res = 0;
            //calculate importance for each road
            foreach((int src, int tgt) r in roads.Select(r => (r[0], r[1])))
                res += (nodeNums[r.src] + nodeNums[r.tgt]);

            return res;
        }
    }
}
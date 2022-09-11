using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumPerformanceOfTeam
{
    public class Solution
    {
        public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
        {
            int MOD = 1_000_000_007;
            var pqEff = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (var i = 0; i < n; i++)
                pqEff.Enqueue(i, efficiency[i]);
            var pqSpeed = new PriorityQueue<int, int>();
            long sum = 0;
            long res = 0;
            var currIdx = 0;
            while (pqEff.Count > 0)
            {
                if (pqSpeed.Count == k)
                    sum -= pqSpeed.Dequeue();
                currIdx = pqEff.Dequeue();
                var curr = speed[currIdx];
                pqSpeed.Enqueue(curr, curr);
                sum += curr;
                res = Math.Max(res, sum * efficiency[currIdx]);
            }

            return (int)(res % MOD);
        }
    }
}
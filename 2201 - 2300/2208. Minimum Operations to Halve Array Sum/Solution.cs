using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumOperationsToHalveArraySum
{
    public class Solution
    {
        public int HalveArray(int[] nums)
        {
            var pq = new PriorityQueue<double, double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));
            var res = 0;
            double sum = 0;
            foreach (var n in nums)
            {
                sum += n;
                pq.Enqueue(n, n);
            }
            sum /= 2;
            while (sum > 0)
            {
                var max = pq.Dequeue();
                max /= 2;
                sum -= max;
                pq.Enqueue(max, max);
                res++;
            }
            return res;
        }
    }
}
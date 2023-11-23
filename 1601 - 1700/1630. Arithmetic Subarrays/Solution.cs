using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ArithmeticSubarrays
{
    public class Solution
    {
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            var res = new bool[l.Length];
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < l.Length; i++)
            {
                for (int j = l[i]; j <= r[i]; j++)
                    pq.Enqueue(nums[j], nums[j]);
                var first = pq.Dequeue();
                var prev = pq.Dequeue();
                var diff = first - prev;
                var allEqual = true;
                while (pq.Count > 0 && allEqual)
                    if (prev - pq.Peek() != diff)
                        allEqual = false;
                    else
                        prev = pq.Dequeue();

                res[i] = allEqual;
                pq.Clear();
            }

            return res;
        }
    }
}
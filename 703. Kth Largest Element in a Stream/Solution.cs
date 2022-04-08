using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KthLargestElementInStream
{
    public class KthLargest
    {
        PriorityQueue<int, int> pq;
        int k;
        public KthLargest(int k, int[] nums)
        {
            pq = new();
            this.k = k;
            foreach (var n in nums)
                pq.Enqueue(n, n);
        }

        public int Add(int val)
        {
            pq.Enqueue(val, val);
            while (pq.Count > k)
                pq.Dequeue();
            return pq.Peek();
        }
    }
}
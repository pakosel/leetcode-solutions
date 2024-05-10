using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace KthSmallestPrimeFraction
{
    public class Solution
    {
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            var pq = new PriorityQueue<(int a, int b), double>();
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    pq.Enqueue((arr[i], arr[j]), arr[i] / (double)arr[j]);
            while (--k > 0)
                pq.Dequeue();
            return new int[] { pq.Peek().a, pq.Peek().b };
        }
    }
}
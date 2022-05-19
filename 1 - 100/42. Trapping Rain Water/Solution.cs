using System.Collections.Generic;
using System.Linq;
using System;

namespace TrappingRainWater
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            var n = height.Length;
            if (n == 0)
                return 0;
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < n; i++)
                pq.Enqueue(i, height[i]);

            var left = pq.Dequeue();
            var right = left;
            var res = 0;
            while (pq.Count > 0)
            {
                var i = pq.Dequeue();
                if (i > left && i < right)
                    res -= height[i];
                else if (i < left)
                {
                    res += height[i] * (left - i - 1);
                    left = i;
                }
                else //if(i > right)
                {
                    res += height[i] * (i - right - 1);
                    right = i;
                }
            }
            return res;
        }
    }
}
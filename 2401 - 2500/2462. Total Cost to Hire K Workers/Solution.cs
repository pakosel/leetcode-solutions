using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TotalCostToHireKWorkers
{
    public class Solution
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            int left = 0, right = costs.Length - 1;
            var pqL = new PriorityQueue<int, int>();
            var pqR = new PriorityQueue<int, int>();
            for (int i = 0; i < candidates && i < costs.Length && left < right; i++)
            {
                pqL.Enqueue(costs[left], costs[left++]);
                pqR.Enqueue(costs[right], costs[right--]);
            }
            if (left == right && pqL.Count < candidates)
                pqL.Enqueue(costs[left], costs[left++]);
            long res = 0;

            while (k-- > 0)
                if (pqR.Count == 0 || (pqL.Count > 0 && pqL.Peek() <= pqR.Peek()))
                {
                    res += pqL.Dequeue();
                    if (left <= right)
                        pqL.Enqueue(costs[left], costs[left++]);
                }
                else
                {
                    res += pqR.Dequeue();
                    if (right >= left)
                        pqR.Enqueue(costs[right], costs[right--]);
                }

            return res;
        }
    }

}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FurthestBuildingYouCanReach
{
    public class Solution
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var sum = 0;
            for (int i = 1; i < heights.Length; i++)
            {
                var diff = heights[i] - heights[i - 1];
                if (diff <= 0)
                    continue;
                sum += diff;    //by default - using bricks to climb the building
                pq.Enqueue(diff, diff);
                while (sum > bricks && ladders > 0 && pq.Count > 0)
                {
                    //not enough bricks - replace some bricks with ladder (greedy)
                    sum -= pq.Dequeue();
                    ladders--;
                }
                if (sum > bricks)   //not enough bricks AND ladders
                    return i - 1;
            }

            return heights.Length - 1;
        }
    }
}
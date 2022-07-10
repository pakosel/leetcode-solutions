using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumAreaOfPieceOfCakeAfterHorizontalAndVerticalCuts
{
    public class Solution
    {
        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            Array.Sort(horizontalCuts);
            Array.Sort(verticalCuts);
            var pqH = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var pqV = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < horizontalCuts.Length - 1; i++)
                pqH.Enqueue(horizontalCuts[i + 1] - horizontalCuts[i], horizontalCuts[i + 1] - horizontalCuts[i]);
            pqH.Enqueue(horizontalCuts[0], horizontalCuts[0]);
            pqH.Enqueue(h - horizontalCuts[horizontalCuts.Length - 1], h - horizontalCuts[horizontalCuts.Length - 1]);
            for (int i = 0; i < verticalCuts.Length - 1; i++)
                pqV.Enqueue(verticalCuts[i + 1] - verticalCuts[i], verticalCuts[i + 1] - verticalCuts[i]);
            pqV.Enqueue(verticalCuts[0], verticalCuts[0]);
            pqV.Enqueue(w - verticalCuts[verticalCuts.Length - 1], w - verticalCuts[verticalCuts.Length - 1]);

            var MOD = 1000_000_007;
            long max = 0;
            long curr = 0;
            while (max <= curr && pqH.Count > 0 && pqV.Count > 0)
            {
                curr = (long)pqH.Dequeue() * pqV.Dequeue();
                max = Math.Max(max, curr);
            }
            return (int)(max % MOD);
        }
    }
}
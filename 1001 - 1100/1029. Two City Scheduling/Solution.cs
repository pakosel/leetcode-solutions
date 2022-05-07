using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace TwoCityScheduling
{
    public class Solution
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            var diffA = new List<int>();
            var diffB = new List<int>();
            var min = 0;
            foreach (var c in costs)
            {
                var diff = Math.Abs(c[0] - c[1]);
                if (c[0] < c[1])
                {
                    min += c[0];
                    diffA.Add(diff);
                }
                else
                {
                    min += c[1];
                    diffB.Add(diff);
                }
            }
            if (diffA.Count == diffB.Count)
                return min;

            var diffMax = diffA.Count > diffB.Count ? diffA : diffB;
            diffMax.Sort();
            var toTake = Math.Abs(diffA.Count - diffB.Count) / 2;
            
            foreach (var d in diffMax.Take(toTake))
                min += d;
            return min;
        }
    }
}
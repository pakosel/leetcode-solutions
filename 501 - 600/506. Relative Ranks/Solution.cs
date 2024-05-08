using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RelativeRanks
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            var medals = new string[] { "Gold Medal", "Silver Medal", "Bronze Medal" };
            var medalsIdx = 0;
            var pq = new PriorityQueue<(int pos, int score), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < score.Length; i++)
                pq.Enqueue((i, score[i]), score[i]);
            var res = new string[score.Length];
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                res[curr.pos] = medalsIdx < 3 ? medals[medalsIdx++] : (++medalsIdx).ToString();
            }
            return res;
        }
    }
}
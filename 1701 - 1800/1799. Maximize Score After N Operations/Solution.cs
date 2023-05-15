using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximizeScoreAfterNOperations
{
    public class Solution
    {
        public int MaxScore(int[] nums)
        {
            var len = nums.Length;
            var pq = new PriorityQueue<(int x, int y, int gcd), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            for (int i = 0; i < len; i++)
                for (int j = i + 1; j < len; j++)
                {
                    var gcd = MathExt.Gcd(nums[i], nums[j]);
                    pq.Enqueue((i, j, gcd), gcd);
                }

            var ordered = new List<(int x, int y, int gcd)>();
            while (pq.Count > 0)
                ordered.Add(pq.Dequeue());
            var done = new HashSet<int>();

            int idx = len / 2;

            return Take(0, idx);

            int Take(int pos, int idx)
            {
                if (pos >= ordered.Count)
                    return 0;
                var i = pos;
                while (i < ordered.Count && (done.Contains(ordered[i].x) || done.Contains(ordered[i].y)))
                    i++;
                if (i >= ordered.Count)
                    return 0;
                if (idx == 1)
                    return ordered[i].gcd;

                done.Add(ordered[i].x);
                done.Add(ordered[i].y);
                var res = idx * ordered[i].gcd + Take(i + 1, idx - 1);
                done.Remove(ordered[i].x);
                done.Remove(ordered[i].y);
                res = Math.Max(res, Take(i + 1, idx));
                return res;
            }
        }
    }
}
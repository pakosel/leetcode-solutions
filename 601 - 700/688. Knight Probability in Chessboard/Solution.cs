using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KnightProbabilityInChessboard
{
    public class Solution
    {
        List<(int r, int c)> moves = new() { (-2, 1), (-1, 2), (1, 2), (2, 1), (2, -1), (1, -2), (-1, -2), (-2, -1) };
        Dictionary<(int, int, int), double> memo = new();

        public double KnightProbability(int n, int k, int row, int col)
        {
            if (k == 0)
                return 1d;
            var key = (row, col, k);
            if (memo.ContainsKey(key))
                return memo[key];
            var q = new Queue<(int r, int c)>();

            var res = 0d;
            foreach (var m in moves)
                if (row + m.r >= 0 && row + m.r < n && col + m.c >= 0 && col + m.c < n)
                    q.Enqueue((row + m.r, col + m.c));
            var cnt = q.Count;
            if (cnt == 0)
                return 0d;
            var factor = cnt / 8d;
            if (k == 1)
            {
                memo[key] = factor;
                return factor;
            }

            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                res += factor * KnightProbability(n, k - 1, curr.r, curr.c);
            }

            memo[key] = res / cnt;
            return memo[key];
        }
    }
}
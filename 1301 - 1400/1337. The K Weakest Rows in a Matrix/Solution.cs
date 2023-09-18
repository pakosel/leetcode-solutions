using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TheKWeakestRowsInMatrix
{
    public class Solution_2023
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var pq = new PriorityQueue<int, (int, int)>(Comparer<(int idx, int pow)>.Create(
                (p, q) => p.pow == q.pow ? p.idx.CompareTo(q.idx) : p.pow.CompareTo(q.pow)));
            for (int r = 0; r < mat.Length; r++)
                pq.Enqueue(r, (r, Calc(mat[r])));
            var res = new List<int>();
            while (k-- > 0)
                res.Add(pq.Dequeue());

            return res.ToArray();

            int Calc(int[] row)
            {
                int res = 0, i = 0;
                while (i < row.Length && row[i++] == 1)
                    res++;
                return res;
            }
        }
    }
    
    public class Solution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            return mat.Select((row, index) => (index, row))
                        .OrderBy(x => x.row.Count(e => e == 1))
                        .ThenBy(x => x.index)
                        .Take(k)
                        .Select(x => x.index).ToArray();
        }
    }
}
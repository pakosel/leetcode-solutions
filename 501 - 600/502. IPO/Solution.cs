using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Ipo
{
    public class Solution
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            var list = new List<(int p, int c)>();
            for (int i = 0; i < profits.Length; i++)
                list.Add((profits[i], capital[i]));
            list.Sort(Comparer<(int p, int c)>.Create((e1, e2) => e1.p == e2.p ? e1.c.CompareTo(e2.c) : e2.p.CompareTo(e1.p)));

            return Greedy(k, w);

            int Greedy(int k, int w)
            {
                var res = 0;
                var idx = -1;

                for (int i = 0; i < list.Count; i++)
                    if (list[i].c <= w)
                    {
                        res = list[i].p;
                        idx = i;
                        break;
                    }
                if (idx < 0)
                    return w;
                if (k == 1)
                    return w + res;
                list.RemoveAt(idx);

                return Greedy(k - 1, w + res);
            }
        }
    }
}
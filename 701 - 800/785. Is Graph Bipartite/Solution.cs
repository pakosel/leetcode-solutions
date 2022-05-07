using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace IsGraphBipartite
{
    public class Solution
    {
        public bool IsBipartite(int[][] graph)
        {
            var len = graph.Length;
            var assign = new int[len];
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            for (int i = 0; i < len; i++)
            {
                if (assign[i] == 0)
                    Assign(i, graph, assign, set1, set2);
                if (!Validate(i, graph[i], assign[i], set1, set2))
                    return false;
            }

            return true;
        }

        private bool Assign(int i, int[][] graph, int[] assign, HashSet<int> set1, HashSet<int> set2)
        {
            if (assign[i] != 0)
                return true;
            var nbs = graph[i];
            var dist = nbs.Select(n => assign[n]).Distinct();
            if (dist.Contains(1) && dist.Contains(2))
                return false;
            if (dist.Contains(1))
            {
                assign[i] = 2;
                set2.Add(i);
                foreach (var n in nbs)
                    if (!Assign(n, graph, assign, set1, set2))
                        return false;
            }
            else
            {
                assign[i] = 1;
                set1.Add(i);
                foreach (var n in nbs)
                    if (!Assign(n, graph, assign, set1, set2))
                        return false;
            }
            return true;
        }

        private bool Validate(int i, int[] nbs, int assignment, HashSet<int> set1, HashSet<int> set2)
        {

            var set = (assignment == 1 ? set1 : set2);

            foreach (var n in nbs)
                if (set.Contains(n))
                    return false;
            return true;
        }
    }
}
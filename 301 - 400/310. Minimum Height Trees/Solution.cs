using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumHeightTrees
{
    public class Solution
    {
        HashSet<int>[] Edges;

        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 1)
                return new int[1] { 0 };
            Edges = new HashSet<int>[n];

            foreach (var pair in edges)
            {
                AddEdge(pair[0], pair[1]);
                AddEdge(pair[1], pair[0]);
            }

            Queue<int> leaves = new Queue<int>();
            for (int i = 0; i < n; i++)
                if (Edges[i].Count == 1)
                    leaves.Enqueue(i);

            while (n > 2)
            {
                List<int> newLeaves = new List<int>();
                while (leaves.Count > 0)
                {
                    n--;
                    var leaf = leaves.Dequeue();
                    var neighbour = Edges[leaf].First();    //the only one
                    Edges[neighbour].Remove(leaf);
                    if (Edges[neighbour].Count == 1)
                        newLeaves.Add(neighbour);
                }
                foreach (var leaf in newLeaves)
                    leaves.Enqueue(leaf);
            }

            List<int> res = new List<int>();
            while (leaves.Count > 0)
                res.Add(leaves.Dequeue());

            return res;
        }

        private void AddEdge(int v1, int v2)
        {
            if (Edges[v1] == null)
                Edges[v1] = new HashSet<int>();
            Edges[v1].Add(v2);
        }
    }

    public class Solution_BFS
    {
        HashSet<int>[] Edges;
        int min = int.MaxValue;

        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 1)
                return new int[1] { 0 };
            Edges = new HashSet<int>[n];

            foreach (var pair in edges)
            {
                AddEdge(pair[0], pair[1]);
                AddEdge(pair[1], pair[0]);
            }

            var maxDist = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                var dist = GetMaxDist(i);
                min = Math.Min(min, dist);
                maxDist.Add((i, dist));
            }

            return maxDist.Where(p => p.Item2 == min).Select(p => p.Item1).ToArray();
        }

        private int GetMaxDist(int vertex)
        {
            HashSet<int> visited = new HashSet<int>();
            int max = 0;
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((vertex, 0));

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                var v = curr.Item1;
                var dist = curr.Item2;
                if (visited.Contains(v))
                    continue;
                visited.Add(v);
                max = Math.Max(max, dist);
                if (max > min)
                    break;
                foreach (int target in Edges[v])
                    if (!visited.Contains(target))
                        queue.Enqueue((target, dist + 1));
            }
            return max;
        }

        private void AddEdge(int v1, int v2)
        {
            if (Edges[v1] == null)
                Edges[v1] = new HashSet<int>();
            Edges[v1].Add(v2);
        }
    }
}
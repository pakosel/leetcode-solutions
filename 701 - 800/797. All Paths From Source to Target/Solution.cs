using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace AllPathsFromSourceToTarget
{
    public class Solution_2022
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var res = new List<IList<int>>();

            var q = new Queue<IList<int>>();
            q.Enqueue(new List<int>() { 0 });
            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                if (curr.Last() == graph.Length - 1)
                    res.Add(curr);
                foreach (var n in graph[curr.Last()])
                {
                    var lst = new List<int>(curr);
                    lst.Add(n);
                    q.Enqueue(lst);
                }
            }
            return res;
        }
    }

    public class Solution
    {
        List<List<int>> res = new List<List<int>>();

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            Helper(graph, new List<int>(), 0);
            return res.ToArray();
        }

        private void Helper(int[][] graph, List<int> path, int start)
        {
            path.Add(start);
            if (start == graph.Length - 1)
                res.Add(path);
            else
                foreach (var n in graph[start])
                    Helper(graph, new List<int>(path), n);
        }
    }
}
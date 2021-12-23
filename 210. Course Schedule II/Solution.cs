using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CourseScheduleII
{
    public class Solution
    {
        HashSet<int> visited = new HashSet<int>();
        Dictionary<int, List<int>> edges = new Dictionary<int, List<int>>();
        Stack<int> ordered = new Stack<int>();

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            foreach (var pair in prerequisites)
            {
                if (!edges.ContainsKey(pair[1]))
                    edges.Add(pair[1], new List<int>());
                edges[pair[1]].Add(pair[0]);
            }

            for (int c = 0; c < numCourses; c++)
                if (!Dfs(new HashSet<int>(), c))
                    return new int[0];

            var res = new int[numCourses];
            var i = 0;
            while (ordered.Count > 0)
                res[i++] = ordered.Pop();
            return res;
        }

        private bool Dfs(HashSet<int> currVisited, int node)
        {
            if (currVisited.Contains(node))
                return false;
            if (visited.Contains(node))
                return true;
            currVisited.Add(node);
            if (edges.ContainsKey(node))
                foreach (var n in edges[node])
                    if (!Dfs(currVisited, n))
                        return false;
            ordered.Push(node);
            visited.Add(node);
            currVisited.Remove(node);
            return true;
        }
    }
}
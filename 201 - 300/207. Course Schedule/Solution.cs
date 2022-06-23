using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CourseSchedule
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var prereq = new List<int>[numCourses];
            foreach (var p in prerequisites)
            {
                if (prereq[p[0]] == null)
                    prereq[p[0]] = new List<int>();
                prereq[p[0]].Add(p[1]);
            }
            var memo = new Dictionary<int, bool>();

            for (int i = 0; i < numCourses; i++)
                if (prereq[i] != null)
                    if (HasCycle(i, new HashSet<int>()))
                        return false;
            return true;

            bool HasCycle(int node, HashSet<int> visited)
            {
                if (visited.Contains(node))
                    return true;
                if (memo.ContainsKey(node))
                    return memo[node];
                visited.Add(node);
                var res = false;
                for (int i = 0; i < prereq[node]?.Count && !res; i++)
                    res |= HasCycle(prereq[node][i], visited);
                visited.Remove(node);
                memo.Add(node, res);
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindIfPathExistsInGraph
{
    public class Solution
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var lookup = edges.ToLookup(e => e[0]);
            var lookupRev = edges.ToLookup(e => e[1]);
            
            var q = new Queue<int>();
            var visited = new HashSet<int>();

            q.Enqueue(source);
            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                if (curr == destination)
                    return true;
                if (visited.Contains(curr))
                    continue;
                visited.Add(curr);

                foreach (var e in lookup[curr])
                    if (!visited.Contains(e[1]))
                        q.Enqueue(e[1]);
                foreach(var e in lookupRev[curr])
                    if(!visited.Contains(e[0]))
                        q.Enqueue(e[0]);
            }
            return false;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NetworkDelayTime
{
    public class Solution
    {
        public int NetworkDelayTime(int[][] times, int N, int K)
        {
            //edge cases
            if (N == 1)
                return 0;

            Dictionary<int, Node> nodes = new Dictionary<int, Node>();
            for (int i = 1; i <= N; i++)
                nodes.Add(i, new Node(i));

            int len = times.Length;
            for (int i = 0; i < len; i++)
            {
                var source = times[i][0];
                var target = times[i][1];
                var weight = times[i][2];

                nodes[source].AddNeighbour(nodes[target], weight);
            }

            Dictionary<int, int> visited = new Dictionary<int, int>();
            visited.Add(K, 0);
            dfs(nodes[K], visited);
            if (visited.Count < N)
                return -1;

            var maxPath = 0;
            for (int i = 1; i <= N; i++)
                maxPath = Math.Max(maxPath, visited[i]);

            return maxPath;
        }

        private void dfs(Node node, Dictionary<int, int> visited)
        {
            var dist = visited[node.Label];
            foreach (var neighbour in node.Neighbours)
            {
                var n = neighbour.Key;
                var distToNeighbour = dist + neighbour.Value;
                if (!visited.ContainsKey(n.Label))
                {
                    visited.Add(n.Label, distToNeighbour);
                    dfs(n, visited);
                }
                else if (distToNeighbour < visited[n.Label])
                    visited[n.Label] = distToNeighbour;
            }
        }

        public class Node
        {
            public int Label;
            public List<KeyValuePair<Node, int>> Neighbours = new List<KeyValuePair<Node, int>>();
            public Node(int label) { Label = label; }
            public void AddNeighbour(Node node, int weight)
            {
                Neighbours.Add(new KeyValuePair<Node, int>(node, weight));
            }
        }
    }
}
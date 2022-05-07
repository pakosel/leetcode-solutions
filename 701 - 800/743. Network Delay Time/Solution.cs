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

            Dictionary<int, int> dist = new Dictionary<int, int>();
            var inf = int.MaxValue / 2;
            foreach(var n in nodes.Keys)
                dist.Add(n, inf);
            dist[K] = 0;
            var nextNodeLabel = SelectNextNode(dist, nodes);
            while(nextNodeLabel != 0)
            {
                Dijkstra(nodes[nextNodeLabel], dist);
                nextNodeLabel = SelectNextNode(dist, nodes);
            }

            if (dist.Any(n => n.Value >= inf))
                return -1;

            var maxPath = dist.Max(n => n.Value);

            return maxPath;
        }

        private int SelectNextNode(Dictionary<int, int> dist, Dictionary<int, Node> nodes) => dist.Where(n => !nodes[n.Key].Done).OrderBy(n => n.Value).FirstOrDefault().Key;

        private void Dijkstra(Node node, Dictionary<int, int> visited)
        {
            var dist = visited[node.Label];
            foreach (var neighbour in node.Neighbours)
            {
                var n = neighbour.Key;
                var distToNeighbour = dist + neighbour.Value;
                if (!visited.ContainsKey(n.Label))
                    visited.Add(n.Label, distToNeighbour);
                else if (distToNeighbour < visited[n.Label])
                    visited[n.Label] = distToNeighbour;
            }
            node.Done = true;
        }

        public class Node
        {
            public int Label;
            public List<KeyValuePair<Node, int>> Neighbours = new List<KeyValuePair<Node, int>>();
            public bool Done = false;
            public Node(int label) { Label = label; }
            public void AddNeighbour(Node node, int weight)
            {
                Neighbours.Add(new KeyValuePair<Node, int>(node, weight));
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CloneGraph
{
    public class Solution_Recursive
    {
        Dictionary<int, Node> Visited = new Dictionary<int, Node>();
        public Node CloneGraph(Node node)
        {
            if (node == null)
                return null;
            if (Visited.ContainsKey(node.val))
                return Visited[node.val];
            var res = new Node(node.val);
            Visited.Add(node.val, res);
            foreach (var n in node.neighbors)
                res.neighbors.Add(CloneGraph(n));
            return res;
        }
    }
    public class Solution
    {
        public Node CloneGraph(Node node)
        {
            if (node == null)
                return null;
            Dictionary<Node, Node> graph = new Dictionary<Node, Node>();

            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(node);
            graph.Add(node, new Node(node.val));

            while (nodes.Count > 0)
            {
                var curr = nodes.Dequeue();

                foreach (var n in curr.neighbors)
                {
                    if (!graph.ContainsKey(n))
                    {
                        graph.Add(n, new Node(n.val));
                        nodes.Enqueue(n);
                    }
                    graph[curr].neighbors.Add(graph[n]);
                }
            }

            return graph[node];
        }
    }

    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
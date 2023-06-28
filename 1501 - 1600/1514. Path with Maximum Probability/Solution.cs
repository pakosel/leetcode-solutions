using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PathWithMaximumProbability
{
    public class Solution
    {
        const double ZERO = 1e-5;
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
        {
            var graph = new Dictionary<int, List<(int node, double p)>>();
            for (int i = 0; i < edges.Length; i++)
            {
                if (!graph.ContainsKey(edges[i][0]))
                    graph.Add(edges[i][0], new List<(int, double)>());
                if (!graph.ContainsKey(edges[i][1]))
                    graph.Add(edges[i][1], new List<(int, double)>());

                graph[edges[i][0]].Add((edges[i][1], succProb[i]));
                graph[edges[i][1]].Add((edges[i][0], succProb[i]));
            }

            var visited = new double[n];

            Dfs(start, 1.0);

            return visited[end];

            void Dfs(int node, double prob)
            {
                if (visited[node] >= prob)
                    return;
                visited[node] = prob;
                if (!graph.ContainsKey(node) || node == end)
                    return;
                foreach (var dest in graph[node])
                    if (prob * dest.p > ZERO && visited[dest.node] < prob * dest.p)
                        Dfs(dest.node, prob * dest.p);
            }
        }
    }
}
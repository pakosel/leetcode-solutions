using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace AllNodesDistanceKInBinaryTree
{
    public class Solution
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            var graph = new Dictionary<int, List<int>>();
            BuildGraph(root);
            var res = new List<int>();
            var visited = new HashSet<int>();
            Dfs(target.val, k);
            return res;

            void Dfs(int node, int k)
            {
                if (!visited.Contains(node) && graph.ContainsKey(node))
                {
                    visited.Add(node);
                    if (k > 0)
                        foreach (var tgt in graph[node])
                            Dfs(tgt, k - 1);
                    else
                        res.Add(node);
                }
            }

            void BuildGraph(TreeNode node)
            {
                if (node.left != null)
                {
                    AddNodes(node.val, node.left.val);
                    BuildGraph(node.left);
                }
                if (node.right != null)
                {
                    AddNodes(node.val, node.right.val);
                    BuildGraph(node.right);
                }
            }

            void AddNodes(int n1, int n2)
            {
                if (!graph.ContainsKey(n1))
                    graph.Add(n1, new List<int>());
                if (!graph.ContainsKey(n2))
                    graph.Add(n2, new List<int>());
                graph[n1].Add(n2);
                graph[n2].Add(n1);
            }
        }
    }
}
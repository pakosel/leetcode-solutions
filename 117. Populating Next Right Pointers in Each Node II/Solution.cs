using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PopulatingNextRightPointersEachNodeII
{
    public class Solution
    {
        Dictionary<int, Node> dict = new Dictionary<int, Node>();

        public Node Connect(Node root)
        {
            Build(root, 0);

            return root;
        }

        private void Build(Node node, int level)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(level))
                dict.Add(level, node);
            else
            {
                dict[level].next = node;
                dict[level] = node;
            }

            Build(node.left, level + 1);
            Build(node.right, level + 1);
        }
    }
}
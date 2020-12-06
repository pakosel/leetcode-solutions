using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PopulatingNextRightPointersEachNodeII
{
    public class Solution
    {
        Dictionary<int, List<Node>> dict = new Dictionary<int, List<Node>>();

        public Node Connect(Node root)
        {
            Build(root, 0);

            int level = 0;
            while (dict.ContainsKey(level))
            {
                int len = dict[level].Count;
                for (int i = 0; i < len - 1; i++)
                    dict[level][i].next = dict[level][i + 1];
                
                dict[level][len - 1].next = null;
                level++;
            }

            return root;
        }

        private void Build(Node node, int level)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(level))
                dict.Add(level, new List<Node>());
            dict[level].Add(node);

            Build(node.left, level + 1);
            Build(node.right, level + 1);
        }
    }
}
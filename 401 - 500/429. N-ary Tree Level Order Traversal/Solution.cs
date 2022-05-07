using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NaryTreeLevelOrderTraversal
{
    public class Solution
    {
        IList<int>[] res;
        public IList<IList<int>> LevelOrder(NodeN root)
        {
            res = new List<int>[1000];
            if (root != null)
                AddNode(root, 0);

            return res.Where(e => e != null).ToList();
        }

        private void AddNode(NodeN node, int level)
        {
            if (res[level] == null)
                res[level] = new List<int>();

            res[level].Add(node.val);
            foreach (var child in node.children)
                AddNode(child, level + 1);
        }
    }
}
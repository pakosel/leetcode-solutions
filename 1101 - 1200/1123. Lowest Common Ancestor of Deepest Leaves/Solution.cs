using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LowestCommonAncestorDeepestLeaves
{
    public class Solution
    {
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            return Deepest(root, 0).Item2;
        }

        private (int, TreeNode) Deepest(TreeNode node, int level)
        {
            if (node == null)
                return (-1, null);
            var left = Deepest(node.left, level + 1);
            var right = Deepest(node.right, level + 1);

            if (left.Item1 == right.Item1)
                return left.Item1 == -1 ? (level, node) : (left.Item1, node);
            else
                return left.Item1 > right.Item1 ? left : right;
        }
    }
}
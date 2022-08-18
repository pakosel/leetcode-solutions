using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LowestCommonAncestorOfBinarySearchTree
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            return Find(root).node;

            (int res, TreeNode node) Find(TreeNode node)
            {
                if (node == null)
                    return (0, null);
                var left = Find(node.left);
                var right = Find(node.right);
                if (left.res > 1)
                    return left;
                if (right.res > 1)
                    return right;
                if (left.res + right.res == 2)
                    return (2, node);
                if (node == p || node == q)
                    return (left.res + right.res + 1, node);
                return (left.res + right.res, null);
            }
        }
    }
}
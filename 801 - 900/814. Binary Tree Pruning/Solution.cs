using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinaryTreePruning
{
    public class Solution
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (Check(root))
                return root;
            return null;

            bool Check(TreeNode node)
            {
                var self = (node.val == 1);
                var left = false;
                var right = false;
                if (node.left != null)
                {
                    left = Check(node.left);
                    if (!left)
                        node.left = null;
                }
                if (node.right != null)
                {
                    right = Check(node.right);
                    if (!right)
                        node.right = null;
                }

                return self || left || right;
            }
        }
    }
}
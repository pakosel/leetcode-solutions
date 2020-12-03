using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace IncreasingOrderSearchTree
{
    public class Solution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public TreeNode IncreasingBST(TreeNode root)
        {
            TraverseLeft(root);
            TreeNode curr = stack.Pop();
            TraverseLeft(curr.right);
            var res = curr;

            while (stack.Count > 0)
            {
                var next = stack.Pop();
                next.left = null;
                TraverseLeft(next.right);
                curr.right = next;
                curr = next;
            }

            return res;
        }

        private void TraverseLeft(TreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }
    }
}
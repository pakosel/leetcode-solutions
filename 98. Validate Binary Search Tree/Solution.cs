using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ValidateBinarySearchTree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return Validate(root.left, null, root.val) && Validate(root.right, root.val, null);
        }

        private bool Validate(TreeNode node, int? min, int? max)
        {
            if (node != null)
            {
                if ((min != null && node.val <= min) || (max != null && node.val >= max))
                    return false;
                return Validate(node.left, min, node.val) && Validate(node.right, node.val, max);
            }
            return true;
        }
    }

    public class Solution_Stack
    {
        Stack<(TreeNode, int?)> stack = new Stack<(TreeNode, int?)>();

        public bool IsValidBST(TreeNode root)
        {
            if (!TraverseLeft(root, null, null))
                return false;
            while (stack.Count > 0)
            {
                var next = stack.Pop();
                var curr = next.Item1;
                var max = next.Item2;
                if (!TraverseLeft(curr.right, curr.val, max))
                    return false;
            }
            return true;
        }

        private bool TraverseLeft(TreeNode node, int? min, int? max)
        {
            while (node != null)
            {
                if ((min != null && node.val <= min) || (max != null && node.val >= max))
                    return false;
                stack.Push((node, max));
                max = node.val;
                node = node.left;
            }
            return true;
        }
    }
}
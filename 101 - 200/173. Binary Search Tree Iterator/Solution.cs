using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinarySearchTreeIterator
{
    public class BSTIterator
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            TraverseLeft(root);
        }

        public int Next()
        {
            var node = stack.Pop();
            TraverseLeft(node.right);
            return node.val;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
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
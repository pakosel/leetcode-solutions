using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LowestCommonAncestorOfBinaryTree
{
    public class Solution_Stack
    {
        // public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        public TreeNode LowestCommonAncestor(TreeNode root, int p, int q)
        {
            var stack1 = FindVal(root, p);
            var stack2 = FindVal(root, q);

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                var peek1 = stack1.Peek();
                var peek2 = stack2.Peek();

                if (peek1.val == peek2.val)
                    return peek1;
                else if (stack1.Count > stack2.Count)
                    stack1.Pop();
                else
                    stack2.Pop();
            }

            return null;
        }

        private Stack<TreeNode> FindVal(TreeNode node, int val)
        {
            HashSet<int> visited = new HashSet<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var peek = stack.Peek();
                if (peek.val == val)
                    return stack;
                if (peek.left != null && !visited.Contains(peek.left.val))
                    stack.Push(peek.left);
                else if (peek.right != null && !visited.Contains(peek.right.val))
                    stack.Push(peek.right);
                else
                {
                    visited.Add(peek.val);
                    stack.Pop();
                }
            }

            return null;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
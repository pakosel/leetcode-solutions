using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SymmetricTree
{
    public class Solution_2023
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Equals(root.left, root.right);

            bool Equals(TreeNode n1, TreeNode n2)
                => (n1 == null && n2 == null) || (n1?.val == n2?.val && Equals(n1?.left, n2?.right) && Equals(n1?.right, n2?.left));
        }
    }
    public class Solution_Recursive
    {
        public bool IsSymmetric(TreeNode root) => CheckSymetry(root?.left, root?.right);

        private bool CheckSymetry(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left?.val == right?.val;
            if (left.val != right.val)
                return false;

            return CheckSymetry(left.left, right.right) && CheckSymetry(left.right, right.left);
        }
    }

    public class Solution_Queue
    {
        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var e1 = queue.Dequeue();
                var e2 = queue.Dequeue();
                if (e1 == null && e2 == null)
                    continue;
                if (e1 == null || e2 == null)
                    return false;
                if (e1.val != e2.val)
                    return false;
                queue.Enqueue(e1.left);
                queue.Enqueue(e2.right);
                queue.Enqueue(e1.right);
                queue.Enqueue(e2.left);
            }

            return true;
        }
    }

    public class Solution_Stack
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            Stack<TreeNode> leftStack = new Stack<TreeNode>();
            Stack<TreeNode> rightStack = new Stack<TreeNode>();

            TraverseLeft(root.left, leftStack);
            TraverseRight(root.right, rightStack);

            while (leftStack.Count > 0 && rightStack.Count > 0)
            {
                if (leftStack.Count != rightStack.Count)
                    return false;

                var leftPop = leftStack.Pop();
                var rightPop = rightStack.Pop();

                if (leftPop.val != rightPop.val)
                    return false;

                TraverseLeft(leftPop.right, leftStack);
                TraverseRight(rightPop.left, rightStack);
            }

            return leftStack.Count == rightStack.Count;
        }

        private void TraverseLeft(TreeNode node, Stack<TreeNode> stack)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }

        private void TraverseRight(TreeNode node, Stack<TreeNode> stack)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.right;
            }
        }
    }
}
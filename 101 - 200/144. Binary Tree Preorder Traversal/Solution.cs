using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinaryTreePreorderTraversal
{
    public class Solution_2022
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            Traverse(root);

            return res;

            void Traverse(TreeNode node)
            {
                if (node == null)
                    return;
                res.Add(node.val);
                Traverse(node.left);
                Traverse(node.right);
            }
        }
    }

    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            var stack = new Stack<TreeNode>();
            if (root == null)
                return res;

            stack.Push(root);
            while (stack.Count() > 0)
            {
                var node = stack.Pop();
                res.Add(node.val);
                if (node.right != null)
                    stack.Push(node.right);
                if (node.left != null)
                    stack.Push(node.left);
            }

            return res;
        }

        public IList<int> BfsTraversal(TreeNode root)
        {
            var res = new List<int>();
            var queue = new Queue<TreeNode>();
            if (root == null)
                return res;

            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                var node = queue.Dequeue();
                res.Add(node.val);
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            return res;
        }
    }
}
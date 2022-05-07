using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BinaryTreePreorderTraversal
{
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
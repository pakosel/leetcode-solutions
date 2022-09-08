using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinaryTreeInorderTraversal
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>(100);
            if (root == null)
                return res;
            Add(root);

            void Add(TreeNode node)
            {
                if (node.left != null)
                    Add(node.left);
                res.Add(node.val);
                if (node.right != null)
                    Add(node.right);
            }

            return res;
        }
    }

    public class Solution_2020
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            TraverseLeft(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                res.Add(node.val);
                TraverseLeft(node.right);
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
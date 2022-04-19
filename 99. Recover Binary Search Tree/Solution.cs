using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RecoverBinarySearchTree
{
    public class Solution
    {
        public void RecoverTree(TreeNode root)
        {
            var list = new List<TreeNode>();
            Inorder(root, new Stack<TreeNode>(), list);

            var arr = list.Select(l => l.val).ToArray();
            Array.Sort(arr);
            for (int i = 0; i < list.Count; i++)
                if (list[i].val != arr[i])
                    list[i].val = arr[i];
        }

        private void Inorder(TreeNode root, Stack<TreeNode> stack, IList<TreeNode> list)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            while (stack.Count > 0)
            {
                var curr = stack.Pop();
                list.Add(curr);
                Inorder(curr.right, stack, list);
            }
        }
    }
}
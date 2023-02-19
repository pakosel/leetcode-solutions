using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BinaryTreeZigzagLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null)
                return res;
            var stack = new Stack<TreeNode>();
            var stackNext = new Stack<TreeNode>();
            stack.Push(root);
            int level = 0;
            while (stack.Count > 0)
            {
                var cnt = stack.Count;
                res.Add(new int[cnt]);
                for (int i = 0; i < cnt; i++)
                {
                    var curr = stack.Pop();
                    res.Last()[i] = curr.val;
                    if (level % 2 == 1)
                    {
                        if (curr.right != null) stackNext.Push(curr.right);
                        if (curr.left != null) stackNext.Push(curr.left);
                    }
                    else
                    {
                        if (curr.left != null) stackNext.Push(curr.left);
                        if (curr.right != null) stackNext.Push(curr.right);
                    }
                }
                (stack, stackNext) = (stackNext, stack);
                level++;
            }
            return res;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RangeSumOfBst
{
    public class Solution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            int res = 0;
            TraverseLeft(root, low);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.val >= low && node.val <= high)
                    res += node.val;
                if (node.val <= high)
                    TraverseLeft(node.right, low);
            }

            return res;
        }

        private void TraverseLeft(TreeNode node, int low)
        {
            while (node != null)
            {
                stack.Push(node);
                if (node.val < low)
                    break;
                node = node.left;
            }
        }
    }
}
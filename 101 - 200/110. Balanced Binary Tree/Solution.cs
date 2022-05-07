using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace BalancedBinaryTree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return CheckBalance(root, 0).Item1;
        }

        (bool, int) CheckBalance(TreeNode root, int depth)
        {
            if (root == null)
                return (true, depth);

            var left = CheckBalance(root.left, depth + 1);
            if (left.Item1)
            {
                var right = CheckBalance(root?.right, depth + 1);
                if (right.Item1 && Math.Abs(left.Item2 - right.Item2) < 2)
                    return (true, Math.Max(left.Item2, right.Item2));
            }

            return (false, depth);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace BinaryTreeMaximumPathSum
{
    public class Solution
    {
        const int MIN = -1_000_000; //based on constraints

        public int MaxPathSum(TreeNode root)
        {
            var res = MIN;

            Sum(root);

            return res;

            int Sum(TreeNode node)
            {
                res = Math.Max(res, node.val);

                var left = node.left == null ? MIN : Sum(node.left);
                var right = node.right == null ? MIN : Sum(node.right);

                res = Math.Max(res, node.val + right);
                res = Math.Max(res, left + node.val);
                res = Math.Max(res, left + node.val + right);

                var max = Math.Max(node.val + left, node.val + right);
                max = Math.Max(max, node.val);

                return max;
            }
        }
    }
}
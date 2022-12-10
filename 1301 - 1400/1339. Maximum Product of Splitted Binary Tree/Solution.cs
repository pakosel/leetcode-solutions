using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumProductOfSplittedBinaryTree
{
    public class Solution
    {
        public int MaxProduct(TreeNode root)
        {
            var dict = new Dictionary<TreeNode, (long lSum, long rSum)>();
            long res = 0;

            CalcSum(root);
            Visit(root, 0);

            return (int)(res % 1_000_000_007);

            int CalcSum(TreeNode node)
            {
                if (node == null)
                    return 0;
                var lSum = CalcSum(node.left);
                var rSum = CalcSum(node.right);

                dict.Add(node, (lSum, rSum));

                return node.val + lSum + rSum;
            }

            void Visit(TreeNode node, long carry)
            {
                if (node == null)
                    return;
                carry += node.val;

                var left = dict[node].lSum;
                var right = dict[node].rSum;

                Visit(node.left, carry + right);
                Visit(node.right, carry + left);

                res = Math.Max(res, Math.Max((long)(carry + left) * right, (long)(carry + right) * left));
            }
        }
    }
}
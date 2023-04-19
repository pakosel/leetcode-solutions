using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LongestZigZagPathInBinaryTree
{
    public class Solution
    {
        public int LongestZigZag(TreeNode root)
        {
            var res = 0;

            Visit(root);

            return res;

            (int left, int right) Visit(TreeNode node)
            {
                if (node == null)
                    return (-1, -1);

                var leftChild = Visit(node.left);
                var rightChild = Visit(node.right);

                res = Math.Max(res, 1 + leftChild.right);
                res = Math.Max(res, 1 + rightChild.left);

                return (1 + leftChild.right, 1 + rightChild.left);
            }
        }
    }
}
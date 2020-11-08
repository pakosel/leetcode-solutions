using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BinaryTreeTilt
{
    public class Solution
    {
        int Sum = 0;
        public int FindTilt(TreeNode root)
        {
            if (root == null)
                return 0;

            GetSumAndTilt(root);
            return Sum;
        }

        private (int, int) GetSumAndTilt(TreeNode node)
        {
            if (node == null)
                return (0, 0);
            (int, int) left = GetSumAndTilt(node.left);
            (int, int) right = GetSumAndTilt(node.right);

            int sum = left.Item1 + right.Item1 + node.val;
            int tilt = Math.Abs(left.Item1 - right.Item1);

            Sum += tilt;
            return (sum, tilt);
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
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BinaryTreeTilt
{
    public class Solution
    {
        int Result = 0;

        public int FindTilt(TreeNode root)
        {
            if (root == null)
                return 0;

            GetSumAndCalcTilt(root);
            return Result;
        }

        private int GetSumAndCalcTilt(TreeNode node)
        {
            if (node == null)
                return 0;
            int leftSum = GetSumAndCalcTilt(node.left);
            int rightSum = GetSumAndCalcTilt(node.right);

            int sum = leftSum + rightSum + node.val;
            int tilt = Math.Abs(leftSum - rightSum);

            Result += tilt;
            return sum;
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
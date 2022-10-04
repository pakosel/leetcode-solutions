using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PathSum
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            targetSum -= root.val;
            if (root.left == null && root.right == null)
                return targetSum == 0;

            return (root.left != null ? HasPathSum(root.left, targetSum) : false) ||
                    (root.right != null ? HasPathSum(root.right, targetSum) : false);
        }
    }
}
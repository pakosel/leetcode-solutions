using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConvertBstToGreaterTree
{
    public class Solution
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            Helper(root, 0);
            return root;
        }

        private int Helper(TreeNode root, int max)
        {
            if (root == null)
                return max;
            root.val += Helper(root.right, max);
            var left = Helper(root.left, root.val);
            return left;
        }
    }
}
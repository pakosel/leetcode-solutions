using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SumOfRootToLeafBinaryNumbers
{
    public class Solution
    {
        public int SumRootToLeaf(TreeNode root)
        {
            return Helper(0, root);
        }

        private int Helper(int val, TreeNode root)
        {
            val = (val << 1) + root.val;
            if (root.left == null && root.right == null)
                return val;

            return (root.left != null ? Helper(val, root.left) : 0) +
                   (root.right != null ? Helper(val, root.right) : 0);
        }
    }
}
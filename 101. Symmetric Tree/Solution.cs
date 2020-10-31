using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root) => CheckSymetry(root?.left, root?.right);

        private bool CheckSymetry(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left?.val == right?.val;
            if (left.val != right.val)
                return false;

            return CheckSymetry(left.left, right.right) && CheckSymetry(left.right, right.left);
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
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SearchInBinarySearchTree
{
    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if (root.val == val)
                return root;
            return root.val < val ? SearchBST(root.right, val) : SearchBST(root.left, val);
        }
    }
}
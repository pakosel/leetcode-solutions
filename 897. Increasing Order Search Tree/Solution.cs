using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace IncreasingOrderSearchTree
{
    public class Solution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode res = null;
            if (root == null)
                return null;
            if (root.left == null)
            {
                res = root;
                res.right = IncreasingBST(root.right);
            }
            else
            {
                res = IncreasingBST(root.left);
                var last = res;
                while (last.right != null)
                    last = last.right;
                root.left = null;
                last.right = IncreasingBST(root);
            }
            return res;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindCorrespondingNodeBinaryTreeInCloneThatTree
{
    public class Solution
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            return Lookup(cloned, target.val);
        }

        private TreeNode Lookup(TreeNode root, int val)
        {
            if (root.val == val)
                return root;
            if (root.left != null)
            {
                var res = Lookup(root.left, val);
                if (res != null)
                    return res;
            }
            if (root.right != null)
            {
                var res = Lookup(root.right, val);
                if (res != null)
                    return res;
            }

            return null;
        }
    }
}
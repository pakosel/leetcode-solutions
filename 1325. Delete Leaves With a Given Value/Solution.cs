using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DeleteLeavesWithGivenValue
{
    public class Solution
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root.left != null)
                root.left = RemoveLeafNodes(root.left, target);
            if (root.right != null)
                root.right = RemoveLeafNodes(root.right, target);

            if (root.val == target && root.left == null && root.right == null)
                return null;
            return root;
        }
    }
}
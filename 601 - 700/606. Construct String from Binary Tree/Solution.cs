using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConstructStringFromBinaryTree
{
    public class Solution
    {
        public string Tree2str(TreeNode root)
        {
            if (root == null)
                return "";
            StringBuilder sb = new();
            sb.Append(root.val);
            if (root.left != null || root.right != null)
                sb.Append("(" + Tree2str(root.left) + ")");
            if (root.right != null)
                sb.Append("(" + Tree2str(root.right) + ")");
            return sb.ToString();
        }
    }
}
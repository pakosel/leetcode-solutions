using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace InvertBinaryTree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root != null)
                (root.left, root.right) = (InvertTree(root.right), InvertTree(root.left));
            return root;
        }
    }
}
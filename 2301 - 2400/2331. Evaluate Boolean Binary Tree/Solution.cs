using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace EvaluateBooleanBinaryTree
{
    public class Solution
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.val == 0)
                return false;
            else if (root.val == 1)
                return true;
            else if (root.val == 2)
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            else
                return EvaluateTree(root.left) && EvaluateTree(root.right);
        }
    }
}
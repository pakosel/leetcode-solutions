using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SumOfLeftLeaves
{
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root, bool isLeft = false)
        {
            if (root == null)
                return 0;
            if (isLeft && root.left == null && root.right == null)
                return root.val;
            return SumOfLeftLeaves(root.left, true) + SumOfLeftLeaves(root.right);
        }
    }
}
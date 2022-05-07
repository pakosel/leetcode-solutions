using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace SumRootToLeafNumbers
{
    public class Solution
    {
        List<string> nums = new List<string>();

        public int SumNumbers(TreeNode root)
        {
            VisitNodes(root, "");
            var res = 0;
            foreach (var n in nums)
                res += int.Parse(n);
            return res;
        }

        private void VisitNodes(TreeNode n, string numStr)
        {
            numStr += n.val;
            if (n.left == null && n.right == null)
                nums.Add(numStr);
            else
            {
                if (n.left != null)
                    VisitNodes(n.left, numStr);
                if (n.right != null)
                    VisitNodes(n.right, numStr);
            }
        }
    }
}
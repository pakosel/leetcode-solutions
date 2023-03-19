using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace SumRootToLeafNumbers
{
    public class Solution_2023
    {
        public int SumNumbers(TreeNode root, int sum = 0)
        {
            sum = 10 * sum + root.val;
            if (root.left == null && root.right == null)
                return sum;
            var res = 0;
            if (root.left != null)
                res += SumNumbers(root.left, sum);
            if (root.right != null)
                res += SumNumbers(root.right, sum);
            return res;
        }
    }
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
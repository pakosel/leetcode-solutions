using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PathSumIII
{
    public class Solution
    {
        private int baseTarget;
        public int PathSum(TreeNode root, int targetSum)
        {
            this.baseTarget = targetSum;
            return GetAllPaths(root, targetSum, true);
        }

        private int GetAllPaths(TreeNode node, int currentTarget, bool runForBaseTarget)
        {
            if (node == null)
                return 0;

            int res = 0;
            if (node.val == currentTarget)
                res++;

            res += GetAllPaths(node.left, currentTarget - node.val, runForBaseTarget);
            if (runForBaseTarget)
                res += GetAllPaths(node.left, baseTarget, false);

            res += GetAllPaths(node.right, currentTarget - node.val, runForBaseTarget);
            if (runForBaseTarget)
                res += GetAllPaths(node.right, baseTarget, false);

            return res;
        }
    }
}
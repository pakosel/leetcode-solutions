using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;
using LowestCommonAncestorDeepestLeaves;

namespace SmallestSubtreeWithDeepestNodes
{
    public class Solution
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            var sol = new LowestCommonAncestorDeepestLeaves.Solution();
            return sol.LcaDeepestLeaves(root);
        }
    }
}
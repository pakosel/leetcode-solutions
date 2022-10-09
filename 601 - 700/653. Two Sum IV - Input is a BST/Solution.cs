using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TwoSumIVInputIsBST
{
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            var set = new HashSet<int>();

            return Visit(root);

            bool Visit(TreeNode node)
            {
                if (node == null)
                    return false;
                if (set.Contains(k - node.val))
                    return true;
                set.Add(node.val);
                return Visit(node.left) || Visit(node.right);
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace HouseRobberIII
{
    public class Solution
    {
        Dictionary<TreeNode, int> maxRob = new Dictionary<TreeNode, int>();

        public int Rob(TreeNode root)
        {
            return GetMaxRob(root);
        }

        private int GetMaxRob(TreeNode node)
        {
            if (node == null)
                return 0;

            if (maxRob.ContainsKey(node))
                return maxRob[node];
            int res = 0;
            if (node.left == null && node.right == null)
                res = node.val;
            else
            {
                int val1 = GetMaxRob(node.left) + GetMaxRob(node.right);
                int val2 = node.val;
                if (node.left != null)
                    val2 += GetMaxRob(node.left.left) + GetMaxRob(node.left.right);
                if (node.right != null)
                    val2 += GetMaxRob(node.right.left) + GetMaxRob(node.right.right);

                res = Math.Max(val1, val2);
            }

            maxRob.Add(node, res);
            return res;
        }
    }
}
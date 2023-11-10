using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindModeInBinarySearchTree
{
    public class Solution
    {
        public int[] FindMode(TreeNode root)
        {
            var dict = new Dictionary<int, int>();
            Visit(root);
            var max = dict.Max(kvp => kvp.Value);

            return dict.Where(kvp => kvp.Value == max).Select(kvp => kvp.Key).ToArray();

            void Visit(TreeNode n)
            {
                if (n == null)
                    return;
                if (dict.ContainsKey(n.val))
                    dict[n.val]++;
                else
                    dict[n.val] = 1;
                Visit(n.left);
                Visit(n.right);
            }
        }
    }
}
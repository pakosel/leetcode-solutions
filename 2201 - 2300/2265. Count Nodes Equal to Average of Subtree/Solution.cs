using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountNodesEqualToAverageOfSubtree
{
    public class Solution
    {
        public int AverageOfSubtree(TreeNode root)
        {
            var res = 0;
            Visit(root);
            return res;

            (int c, int s) Visit(TreeNode n)
            {
                if (n == null)
                    return (0, 0);
                var l = Visit(n.left);
                var r = Visit(n.right);
                var c = l.c + r.c + 1;
                var s = l.s + r.s + n.val;
                if (n.val == s / c)
                    res++;
                return (c, s);
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumDifferenceBetweenNodeAncestor
{
    public class Solution
    {
        int max = 0;
        public int MaxAncestorDiff(TreeNode root)
        {
            Helper(root);

            return max;
        }

        (int min, int max) Helper(TreeNode node)
        {
            if(node == null)
                return (-1, -1);

            var left = Helper(node.left);
            var right = Helper(node.right);
            var maxDiff = MaxDiff(left, right, node.val);

            //both childs are null
            if(maxDiff.max == -1)
                return (node.val, node.val);

            return (maxDiff.min != -1 ? Math.Min(maxDiff.min, node.val) : Math.Min(maxDiff.max, node.val), Math.Max(maxDiff.max, node.val));
        }

        private (int min, int max) MaxDiff((int min, int max) left, (int min, int max) right, int val)
        {
            var mx = Math.Max(left.max, right.max);
            var mi = Math.Min(left.min, right.min);

            //both childs are null
            if(mx == -1)
                return (-1, -1);
            //one of the childs is null
            if(mi == -1)
                mi = Math.Max(left.min, right.min);

            max = Math.Max(max, Math.Max(Math.Abs(val - mx), Math.Abs(val - mi)));

            return (mi, mx);
        }
    }
}
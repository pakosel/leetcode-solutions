using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SameTree
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null) return q == null;
            if (q == null) return p == null;

            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
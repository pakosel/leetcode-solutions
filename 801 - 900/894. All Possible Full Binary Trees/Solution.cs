using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace AllPossibleFullBinaryTrees
{
    public class Solution
    {
        Dictionary<int, List<TreeNode>> dict = new();

        public IList<TreeNode> AllPossibleFBT(int n)
        {
            var res = new List<TreeNode>();
            if (n % 2 == 0)
                return res;
            if (dict.ContainsKey(n))
                return dict[n];
            if (n == 1)
                res.Add(new TreeNode(0));
            else
                for (int i = 1; i <= n - 2; i += 2)
                {
                    var left = AllPossibleFBT(i);
                    var right = AllPossibleFBT(n - i - 1);
                    foreach (var l in left)
                        foreach (var r in right)
                            res.Add(new TreeNode(0, l, r));
                }

            dict[n] = res;

            return res;
        }
    }
}
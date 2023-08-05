using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace UniqueBinarySearchTreesII
{
    public class Solution
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            var memo = new Dictionary<(int, int), IList<TreeNode>>();

            return Memo(1, n);

            IList<TreeNode> Memo(int min, int max)
            {
                var key = (min, max);
                if (memo.ContainsKey(key))
                    return memo[key];
                var res = new List<TreeNode>();
                if (min > max)
                    return res;

                if (min == max)
                    res.Add(new TreeNode(min));
                else
                    for (int i = min; i <= max; i++)
                    {
                        var allLeft = Memo(min, i - 1);
                        var allRight = Memo(i + 1, max);
                        if (allLeft.Count == 0)
                            foreach (var right in allRight)
                                res.Add(new TreeNode(i, null, right));
                        else if (allRight.Count == 0)
                            foreach (var left in allLeft)
                                res.Add(new TreeNode(i, left, null));
                        else
                            foreach (var left in allLeft)
                                foreach (var right in allRight)
                                    res.Add(new TreeNode(i, left, right));
                    }

                memo[key] = res;
                return res;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace Permutations
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
                res.AddRange(Dfs(new List<int>() { nums[i] }, new HashSet<int>() { i }));
            return res;

            List<IList<int>> Dfs(List<int> src, HashSet<int> visited)
            {
                var res = new List<IList<int>>();
                if (src.Count == nums.Length)
                    res.Add(src);
                else
                    for (int i = 0; i < nums.Length; i++)
                        if (!visited.Contains(i))
                        {
                            var srcNew = new List<int>(src);
                            srcNew.Add(nums[i]);
                            var visitedNew = new HashSet<int>(visited);
                            visitedNew.Add(i);
                            res.AddRange(Dfs(srcNew, visitedNew));
                        }
                return res;
            }
        }
    }
}
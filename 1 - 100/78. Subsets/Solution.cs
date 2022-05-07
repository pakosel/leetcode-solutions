using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Subsets
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var sets = GetSets(nums, 0);
            sets.Add(new List<int>());
            return sets;
        }

        private IList<IList<int>> GetSets(int[] nums, int start)
        {
            var res = new List<IList<int>>();
            res.Add(new List<int>() { nums[start] });
            if (start < nums.Length - 1)
            {
                var sub = GetSets(nums, start + 1);
                foreach (var s in sub)
                {
                    res.Add(new List<int>(s));
                    s.Insert(0, nums[start]);
                }
                res.AddRange(sub);
            }
            return res;
        }
    }
}
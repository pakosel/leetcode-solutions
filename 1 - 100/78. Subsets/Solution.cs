using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Subsets
{
    public class Solution2024
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            return AllSets(nums.Length - 1, new List<IList<int>>() { new List<int>() });

            IList<IList<int>> AllSets(int idx, IList<IList<int>> sets)
            {
                if (idx < 0)
                    return sets;
                var newElems = new List<List<int>>();
                foreach (var e in sets)
                {
                    var newList = new List<int>(e) { nums[idx] };
                    newElems.Add(newList);
                }

                foreach (var e in newElems)
                    sets.Add(e);
                return AllSets(idx - 1, sets);
            }
        }
    }
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
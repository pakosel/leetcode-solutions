using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TheNumberOfBeautifulSubsets
{
    public class Solution
    {
        public int BeautifulSubsets(int[] nums, int k)
        {
            var res = 0;
            foreach (var subset in Subsets(nums, k))
                if (Check(subset))
                    res++;
            return res;

            bool Check(IList<int> subset)
            {
                if (subset.Count == 0)
                    return false;
                var hashSet = new HashSet<int>(subset);
                foreach (var e in hashSet)
                    if (hashSet.Contains(e + k))
                        return false;
                return true;
            }
        }
        //LT#78
        public IList<IList<int>> Subsets(int[] nums, int k)
        {
            return AllSets(nums.Length - 1, new List<IList<int>>() { new List<int>() });

            IList<IList<int>> AllSets(int idx, IList<IList<int>> sets)
            {
                if (idx < 0)
                    return sets;
                var newElems = new List<List<int>>();
                foreach (var e in sets)
                {
                    if (e.Any(el => Math.Abs(el - nums[idx]) == k))
                        continue;
                    var newList = new List<int>(e) { nums[idx] };
                    newElems.Add(newList);
                }

                foreach (var e in newElems)
                    sets.Add(e);
                return AllSets(idx - 1, sets);
            }
        }
    }

}
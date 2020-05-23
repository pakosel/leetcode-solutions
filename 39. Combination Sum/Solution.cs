using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CombinationSum
{
    public class Solution
    {
        Dictionary<int, List<IList<int>>> cache = new Dictionary<int, List<IList<int>>>();
        int[] candidates;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            this.candidates = candidates;
            return FindSumCombinations(target);
        }

        private List<IList<int>> FindSumCombinations(int target)
        {
            var res = new List<IList<int>>();

            if (target <= 0)
                return res;
            if (cache.ContainsKey(target))
                return cache[target];

            foreach (var candidate in candidates)
            {
                var lookingFor = target - candidate;
                if (lookingFor < 0)
                    continue;

                if (lookingFor == 0)
                    res.Add(new List<int>() { candidate });
                else
                {
                    var subCombinations = FindSumCombinations(lookingFor);
                    if (subCombinations.Count == 0)
                        continue;
                    foreach (var combination in subCombinations)
                    {
                        var newItem = new List<int>(combination);
                        newItem.Add(candidate);
                        newItem.Sort();
                        if (!res.Any(l => l.SequenceEqual(newItem)))
                            res.Add(newItem);
                    }
                }
            }

            cache.Add(target, res);
            return res;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CombinationSum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var res = new List<IList<int>>();
            for (int i = 0; i < candidates.Length; i++)
                if (candidates[i] == target)
                    res.Add(new List<int>() { candidates[i] });
                else if (candidates[i] < target)
                {
                    var temp = candidates[i];
                    var sub = CombinationSum(candidates, target - temp);
                    if (sub != null)
                        foreach (var s in sub)
                        {
                            s.Add(candidates[i]);
                            ((List<int>)s).Sort();
                            if (!res.Any(e => e.SequenceEqual(s)))
                                res.Add(s);
                        }
                }
            return res;
        }
    }
}
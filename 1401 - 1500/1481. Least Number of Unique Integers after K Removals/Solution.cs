using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LeastNumberOfUniqueIntegersAfterRemovals
{
    public class Solution
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var ordered = arr.GroupBy(_ => _).ToDictionary(g => g.Key, g => g.Count()).OrderBy(kvp => kvp.Value).ToList();
            int i = 0;
            for (i = 0; i < ordered.Count; i++)
            {
                var kvp = ordered[i];
                if (kvp.Value <= k)
                    k -= kvp.Value;
                else
                {
                    i--;
                    break;
                }
            }

            return Math.Max(ordered.Count - i - 1, 0);
        }
    }
}
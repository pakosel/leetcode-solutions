using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SumOfAllSubsetXorTotals
{
    public class Solution
    {
        public int SubsetXORSum(int[] nums)
        {
            return XorAll(new List<int>(), nums.Length - 1);

            int XorAll(List<int> subsets, int idx)
            {
                if (idx < 0)
                    return subsets.Sum();

                var newElems = new List<int>();
                foreach (var e in subsets)
                    newElems.Add(nums[idx] ^ e);
                newElems.Add(nums[idx]);
                subsets.AddRange(newElems);

                return XorAll(subsets, idx - 1);
            }
        }
    }
}
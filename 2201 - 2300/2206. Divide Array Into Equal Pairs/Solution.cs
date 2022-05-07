using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace DivideArrayIntoEqualPairs
{
    public class Solution
    {
        public bool DivideArray(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
                if (!dict.ContainsKey(n))
                    dict.Add(n, 1);
                else
                    dict[n]++;
            return dict.All(kvp => kvp.Value % 2 == 0);
        }
    }
}
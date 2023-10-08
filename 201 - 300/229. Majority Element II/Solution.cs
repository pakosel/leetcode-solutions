using System.Collections.Generic;
using System.Linq;
using System;

namespace MajorityElementII
{
    public class Solution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            var threshold = nums.Length / 3;
            var res = new HashSet<int>();
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (dict.ContainsKey(n))
                    dict[n]++;
                else
                    dict.Add(n, 1);
                if (dict[n] > threshold)
                    res.Add(n);
            }

            return res.ToList();
        }
    }
}
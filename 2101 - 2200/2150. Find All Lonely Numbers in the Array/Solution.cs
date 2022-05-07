using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindAllLonelyNumbersInTheArray
{
    public class Solution
    {
        public IList<int> FindLonely(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
                if (!dict.ContainsKey(n))
                    dict.Add(n, 1);
                else
                    dict[n]++;

            return nums.Where(n => dict[n] == 1 && !dict.ContainsKey(n - 1) && !dict.ContainsKey(n + 1)).ToList();
        }
    }
}
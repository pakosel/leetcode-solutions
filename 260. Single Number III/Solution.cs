using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace SingleNumberIII
{
    public class Solution
    {
        public int[] SingleNumber(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var n in nums)
                if (hashSet.Contains(n))
                    hashSet.Remove(n);
                else
                    hashSet.Add(n);

            return hashSet.ToArray();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NumberOfGoodPairs
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var arr = new int[101];
            var res = 0;
            foreach (var n in nums)
                arr[n]++;
            foreach (var n in nums)
                res += --arr[n];
            return res;
        }
    }
}
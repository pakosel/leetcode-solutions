using System.Collections.Generic;
using System.Linq;
using System;
using Common;

namespace MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            return nums.GroupBy(_ => _).Select(x => new { Key = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).Select(x => x.Key).First();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace IntersectionOfTwoArraysII
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var arr = new int[1001];
            foreach (var e in nums1)
                arr[e]++;
            var res = new List<int>();
            foreach (var e in nums2)
                if (arr[e]-- > 0)
                    res.Add(e);
            return res.ToArray();
        }
    }
}
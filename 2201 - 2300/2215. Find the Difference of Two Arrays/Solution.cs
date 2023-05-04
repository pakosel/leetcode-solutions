using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheDifferenceOfTwoArrays
{
    public class Solution
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var set1 = nums1.ToHashSet<int>();
            var set2 = nums2.ToHashSet<int>();

            return new IList<int>[] { set1.Where(n => !set2.Contains(n)).ToList(), set2.Where(n => !set1.Contains(n)).ToList() };
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortArrayByIncreasingFrequency
{
    public class Solution
    {
        public int[] FrequencySort(int[] nums)
        {
            var freq = new int[201];
            foreach (var num in nums)
                freq[num + 100]++;
            Array.Sort(nums, (n1, n2) => freq[n1 + 100] != freq[n2 + 100] ? freq[n1 + 100].CompareTo(freq[n2 + 100]) : n2.CompareTo(n1));
            return nums;
        }
    }
}
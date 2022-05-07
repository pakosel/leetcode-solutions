using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PartitionArrayAccordingToGivenPivot
{
    public class Solution
    {
        public int[] PivotArray(int[] nums, int pivot)
        {
            var res = new List<int>();
            var ctEqual = 0;
            foreach (var n in nums)
                if (n < pivot)
                    res.Add(n);
                else if (n == pivot)
                    ctEqual++;
            for (int i = 0; i < ctEqual; i++)
                res.Add(pivot);
            foreach (var n in nums)
                if (n > pivot)
                    res.Add(n);
            return res.ToArray();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;

namespace SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var idx = Array.BinarySearch(nums, target);
            if (idx < 0)
                idx = ~idx;
            return idx;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RemoveDuplicatesFromSortedArrayII
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int cnt = 0;
            int idx = 1;
            int i = 1;
            while (i < nums.Length)
            {
                if (nums[i - 1] == nums[i])
                    cnt++;
                else
                    cnt = 0;
                if (cnt < 2)
                    nums[idx++] = nums[i];

                i++;
            }

            return idx;
        }
    }
}
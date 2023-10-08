using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MonotonicArray
{
    public class Solution
    {
        public bool IsMonotonic(int[] nums)
        {
            bool canInc = true, canDec = true;
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] < nums[i - 1])
                    if (!canDec)
                        return false;
                    else
                        canInc = false;
                else if (nums[i] > nums[i - 1])
                    if (!canInc)
                        return false;
                    else
                        canDec = false;
            return true;
        }
    }
}
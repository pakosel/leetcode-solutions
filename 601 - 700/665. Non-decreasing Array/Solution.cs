using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace NondecreasingArray
{
    public class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            var done = false;
            int i = 1;
            int prev = nums[0];
            for (i = 1; i < nums.Length; i++)
                if (nums[i] < prev)
                    if (done)
                        break;
                    else
                    {
                        prev = nums[i - 1];
                        done = true;
                    }
                else
                    prev = nums[i];

            if (i == nums.Length)
                return true;
            prev = nums.Last();
            done = false;
            for (i = nums.Length - 2; i >= 0; i--)
                if (nums[i] > prev)
                    if (done)
                        break;
                    else
                    {
                        prev = nums[i + 1];
                        done = true;
                    }
                else
                    prev = nums[i];
            return i < 0;
        }
    }
}
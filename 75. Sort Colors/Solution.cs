using System.Collections.Generic;
using System.Linq;
using System;

namespace SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int len = nums.Length;
            if (len < 2)
                return;

            int red = 0, white = 0, blue = 0;
            for (int i = 0; i < len; i++)
                if (nums[i] == 0)
                    red++;
                else if (nums[i] == 1)
                    white++;
                else
                    blue++;

            int idx = 0;
            while (red-- > 0)
                nums[idx++] = 0;
            while (white-- > 0)
                nums[idx++] = 1;
            while (blue-- > 0)
                nums[idx++] = 2;
        }
    }
}
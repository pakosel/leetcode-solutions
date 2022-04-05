using System.Collections.Generic;
using System.Linq;
using System;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var top = height.Max();
            var res = 0;
            var left = 0;
            var right = height.Length - 1;
            for (int i = 1; i <= top; i++)
            {
                while (height[left] < i)
                    left++;
                while (height[right] < i)
                    right--;
                var area = (right - left) * i;
                res = Math.Max(res, area);
            }

            return res;
        }
    }
}
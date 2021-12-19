using System.Collections.Generic;
using System.Linq;
using System;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            var left = -1;
            for (int i = 0; i < height.Length - 1; i++)
            {
                if (left != -1 && height[i] <= height[left])
                    continue;
                var m = MaxContainer(height, i);
                if (m > max)
                {
                    max = m;
                    left = i;
                }
            }
            return max;
        }

        private int MaxContainer(int[] height, int start)
        {
            var max = 0;
            var right = -1;
            var left = height[start];

            for (int i = height.Length - 1; i > start; i--)
            {
                if (right != -1 && height[i] <= height[right])
                    continue;
                var m = (i - start) * Math.Min(left, height[i]);
                if (m > max)
                    max = m;
            }

            return max;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumProductSubarray
{
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            var len = nums.Length;
            var max = nums[0];
            var prod = 1;
            var start = 0;
            var end = 0;
            while (end < len)
            {
                if (nums[end] == 0)
                {
                    if (prod < 0)
                    {
                        prod = Optimize(nums, start, end - 1, prod);
                        max = Math.Max(0, Math.Max(max, prod));
                    }
                    start = end + 1;
                }
                else if (start == end)
                {
                    prod = nums[start];
                    max = Math.Max(max, prod);
                }
                else
                {
                    prod *= nums[end];
                    max = Math.Max(max, prod);
                }
                end++;
            }

            if (prod < 0)
            {
                prod = Optimize(nums, start, end - 1, prod);
                max = Math.Max(max, prod);
            }

            return max;
        }

        private int Optimize(int[] nums, int start, int end, int prod)
        {
            var diff = end - start;
            if (diff == 0)
                return prod;

            //no need to calculate leftProd - it's done in the main loop
            // var leftProd = prod;
            // int i = end;
            // while (i > start && leftProd < 0)
            //     leftProd /= nums[i--];
            var rightProd = prod;
            var i = start;
            while (i < end && rightProd < 0)
                rightProd /= nums[i++];
            
            return Math.Max(prod, rightProd);
        }
    }
}
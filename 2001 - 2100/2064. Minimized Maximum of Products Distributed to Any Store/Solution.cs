using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimizedMaximumOfProductsDistributedToAnyStore
{
    public class Solution
    {
        public int MinimizedMaximum(int n, int[] quantities)
        {
            var left = 1;
            var right = 1_00_001;
            var res = 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (Test(quantities, n, mid))
                {
                    res = mid;
                    right = mid;
                }
                else
                    left = mid + 1;
            }

            return res;
        }

        private bool Test(int[] quantities, int n, int k)
        {
            int i = 0;
            while (i < quantities.Length && n > 0)
            {
                n -= (int)Math.Ceiling((double)quantities[i++] / k);
                ///equivallent to the below lines:
                // n -= (quantities[i] / k);
                // if(quantities[i] % k != 0)
                //     n--;
                // i++;
            }

            return i == quantities.Length && n >= 0;
        }
    }

}
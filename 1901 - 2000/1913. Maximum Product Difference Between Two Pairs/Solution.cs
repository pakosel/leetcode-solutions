using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumProductDifferenceBetweenTwoPairs
{
    public class Solution
    {
        public int MaxProductDifference(int[] nums)
        {
            var max1 = -1;
            var max2 = -1;
            var min1 = int.MaxValue;
            var min2 = int.MaxValue;

            foreach (var n in nums)
                Elect(n);
            return (max1 * max2) - (min1 * min2);

            void Elect(int n)
            {
                if (n == -1 || n == int.MaxValue)
                    return;

                int temp = 0;
                if (n > max1)
                    (temp, max1) = (max1, n);
                else if (n > max2)
                    (temp, max2) = (max2, n);
                else if (n < min1)
                    (temp, min1) = (min1, n);
                else if (n < min2)
                    (temp, min2) = (min2, n);
                
                Elect(temp);
            }
        }
    }
}
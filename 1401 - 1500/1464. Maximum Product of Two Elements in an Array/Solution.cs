using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumProductOfTwoElementsInArray
{
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            int max1 = -1, max2 = -1;

            foreach (var n in nums)
                if (n > max1)
                {
                    max1 = n;
                    if (max1 > max2)
                        (max1, max2) = (max2, max1);
                }
            return (max1 - 1) * (max2 - 1);
        }
    }
}
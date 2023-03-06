using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KthMissingPositiveNumber
{
    public class Solution
    {
        public int FindKthPositive(int[] arr, int k)
        {
            foreach (var e in arr)
                if (e <= k)
                    k++;
                else
                    break;
            return k;
        }
    }
}
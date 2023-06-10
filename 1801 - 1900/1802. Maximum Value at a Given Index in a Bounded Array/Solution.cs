using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MaximumValueAtGivenIndexInBoundedArray
{
    public class Solution
    {
        public int MaxValue(int n, int index, int maxSum)
        {
            var res = 1;
            var sum = n;
            int left = index, right = index;
            while (sum + (right - left + 1) <= maxSum)
            {
                if (left == 0 && right == n - 1)
                {
                    var diff = maxSum - sum;
                    res += diff / n;
                    sum += diff;
                    break;
                }
                else
                {
                    res++;
                    sum += (right - left + 1);
                    if (left - 1 >= 0)
                        left--;
                    if (right + 1 < n)
                        right++;
                }
            }
            return res;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortIntegersByTheNumberOf1Bits
{
    public class Solution
    {
        public int[] SortByBits(int[] arr)
        {
            Array.Sort(arr, (x, y) => CompByBits(x, y));

            return arr;

            int CompByBits(int i1, int i2)
            {
                var b1 = CalcBits(i1);
                var b2 = CalcBits(i2);

                if (b1 < b2)
                    return -1;
                else if (b1 > b2)
                    return 1;
                else
                    return i1.CompareTo(i2);
            }

            int CalcBits(int i)
            {
                var res = 0;
                while (i > 0)
                {
                    if ((i & 1) == 1)
                        res++;
                    i >>= 1;
                }
                return res;
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LargestTripleProduct
{
    public class Solution
    {
        public static int[] findMaxProduct(int[] arr)
        {
            var maxValues = new int[3];

            int len = arr.Length;
            var ret = new int[len];

            for (int i = 0; i < len; i++)
            {
                AddToMaxArr(maxValues, arr[i]);
                if (i < 2)
                    ret[i] = -1;
                else
                    ret[i] = maxValues[0] * maxValues[1] * maxValues[2];
            }

            return ret;
        }

        private static void AddToMaxArr(int[] maxValues, int val)
        {
            if (val > maxValues[0])
            {
                maxValues[0] = val;
                Array.Sort(maxValues);
            }
        }
    }
}
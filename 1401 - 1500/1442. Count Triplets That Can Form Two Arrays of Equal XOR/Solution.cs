using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountTripletsThatCanFormTwoArraysOfEqualXor
{
    public class Solution
    {
        public int CountTriplets(int[] arr)
        {
            var len = arr.Length;
            var xor = new int[len];
            xor[0] = arr[0];

            for (int i = 1; i < len; i++)
                xor[i] = xor[i - 1] ^ arr[i];

            var res = 0;
            for (int i = 0; i < len - 1; i++)
                for (int j = i + 1; j < len; j++)
                    for (int k = j; k < len; k++)
                        res += Check(i, j, k);
            return res;

            int Check(int i, int j, int k)
            {
                var a = (i == 0 ? xor[j - 1] : xor[j - 1] ^ xor[i - 1]);
                var b = xor[k] ^ xor[j - 1];

                return a == b ? 1 : 0;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace MaximumLengthOfPairChain
{
    public class Solution
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, new ArrayComparer());

            int result = 0;
            int curr = int.MinValue;
            foreach(var p in pairs)
            {
                if(curr < p[0])
                {
                    result++;
                    curr = p[1];
                }
            }

            return result;

        }
        private class ArrayComparer : IComparer
        {
            public int Compare(object arr1, object arr2) => ((int[])arr1)[1].CompareTo(((int[])arr2)[1]);
        }
    }
}
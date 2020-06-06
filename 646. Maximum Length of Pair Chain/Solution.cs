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
            Array.Sort(pairs, (arr1, arr2) => arr1[1].CompareTo(arr2[1]));

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
    }
}
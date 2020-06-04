using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MaximumLengthOfPairChain
{
    public class Solution
    {
        Dictionary<int[], int> memoArr = new Dictionary<int[], int>();

        public int FindLongestChain(int[][] pairs, int[] startPair = null)
        {
            if (pairs.Length == 0)
                return 0;

            if (startPair != null && memoArr.ContainsKey(startPair))
                return memoArr[startPair];

            int result = 1;
            foreach (var p in pairs)
            {
                if (startPair != null)
                {
                    if (startPair[1] < p[0])
                        result = Math.Max(result, 1 + FindLongestChain(pairs, p));
                }
                else
                    result = Math.Max(result, FindLongestChain(pairs, p));
            }
            if (startPair != null)
                memoArr.Add(startPair, result);

            return result;

        }
    }
}
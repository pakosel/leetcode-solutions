using System;
using System.Collections;
using System.Collections.Generic;

namespace PairSums
{
    public class Solution
    {
        public static int numberOfWays(int[] arr, int k)
        {
            var validPairs = 0;
            var len = arr.Length;
            if (len == 0)
                return 0;

            Dictionary<int, List<int>> values = new Dictionary<int, List<int>>();
            for (int i = 0; i < len; i++)
            {
                var val = arr[i];

                //check if corresponding value exists
                var lookingFor = k - val;
                if (values.ContainsKey(lookingFor))
                    validPairs += values[lookingFor].Count;

                if (values.ContainsKey(val))
                    values[val].Add(i);
                else
                    values.Add(val, new List<int>() { i });
            }

            return validPairs;
        }

    }
}
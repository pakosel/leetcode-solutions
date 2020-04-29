using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BalancedSplit
{
    public class Solution
    {
        public static bool balancedSplitExists(int[] arr)
        {
            int len = arr.Length;
            if(len < 2)
                return false;

            Array.Sort(arr);
            
            int sum = 0;
            Dictionary<int, List<int>> sumsByIdx = new Dictionary<int, List<int>>();

            for(int i=0; i<len; i++)
            {
                sum += arr[i];
                if(sumsByIdx.ContainsKey(sum))
                    sumsByIdx[sum].Add(i);
                else
                    sumsByIdx.Add(sum, new List<int>() { i });
            }

            if(sum % 2 == 0)
            {
                var target = sum / 2;
                if(sumsByIdx.ContainsKey(target))
                {
                    foreach(int i in sumsByIdx[target])
                        if(i < len-1 && arr[i] < arr[i+1])
                            return true;
                }
            }
            
            return false;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace MedianStream
{
    public class Solution
    {
        public static int[] findMedian(int[] arr)
        {
            int len = arr.Length;
            if (len == 0)
                return new int[0];

            int[] res = new int[len];
            var lowHeap = new SortedSet<int>();
            var highHeap = new SortedSet<int>();
            lowHeap.Add(arr[0]);
            res[0] = arr[0];

            for (int i = 1; i < len; i++)
            {
                var el = arr[i];
                if (el < lowHeap.Max)
                    lowHeap.Add(el);
                else
                    highHeap.Add(el);
                BalanceHeaps(lowHeap, highHeap);
                res[i] = CalculateMedian(lowHeap, highHeap);
            }

            return res;
        }

        private static void BalanceHeaps(SortedSet<int> lowHeap, SortedSet<int> highHeap)
        {
            if(lowHeap.Count > highHeap.Count + 1)
            {
                var max = lowHeap.Max;
                highHeap.Add(max);
                lowHeap.Remove(max);
            }
            else if(highHeap.Count > lowHeap.Count + 1)
            {
                var min = highHeap.Min;
                lowHeap.Add(min);
                highHeap.Remove(min);
            }
        }

        private static int CalculateMedian(SortedSet<int> lowHeap, SortedSet<int> highHeap)
        {
            var max = lowHeap.Max;
            var min = highHeap.Min;
            if(lowHeap.Count > highHeap.Count)
                return max;
            else if(highHeap.Count > lowHeap.Count)
                return min;
            else
                return (max + min) / 2;
        }
    }
}
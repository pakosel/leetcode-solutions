using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Collections;

namespace LongestIncreasingSubsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            SortedSet<Tuple<int, int>> heap = new SortedSet<Tuple<int, int>>(new TupleComparer());
            for (int i = 0; i < nums.Length; i++)
                heap.Add(new Tuple<int, int>(nums[i], i));

            int res = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int currRes = 0;

            while (heap.Count > 0)
            {
                var tuple = heap.Min;
                Console.Out.WriteLine($"min = ({tuple.Item1}, {tuple.Item2})");
                if (tuple.Item2 < min)
                {
                    res = Math.Max(res, currRes);
                    min = tuple.Item2;
                    max = tuple.Item2;
                    currRes = 1;
                }
                else if (tuple.Item2 > max)
                    currRes++;
                heap.Remove(tuple);
            }

            return res;
        }

        private class TupleComparer : IComparer<Tuple<int, int>>
        {
            public int Compare(Tuple<int, int> t1, Tuple<int, int> t2) => t1.Item1.CompareTo(t2.Item1);
        }
    }

}
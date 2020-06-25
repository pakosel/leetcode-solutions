using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace FindPairsWithSmallestSums
{
    public class Solution
    {
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int idx = 0;

            Tuple<int, int>[] arr = new Tuple<int, int>[len1 * len2];
            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                    arr[idx++] = new Tuple<int, int>(nums1[i], nums2[j]);
            Array.Sort(arr, (e1, e2) => (e1.Item1 + e1.Item2).CompareTo(e2.Item1 + e2.Item2));

            idx = 0;
            IList<IList<int>> res = new List<IList<int>>();
            while (k > 0 && idx < arr.Length)
            {
                res.Add(new int[] { arr[idx].Item1, arr[idx].Item2 });
                k--;
                idx++;
            }

            return res;
        }
    }
}
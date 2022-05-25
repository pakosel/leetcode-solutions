using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MostBeautifulItemForEachQuery
{
    public class Solution
    {
        public int[] MaximumBeauty(int[][] items, int[] queries)
        {
            Array.Sort(items, (i1, i2) => i1[0].CompareTo(i2[0]));
            var dict = new Dictionary<int, int>();
            var maxBeauty = 0;
            foreach ((int p, int b) in items.Select(it => (it[0], it[1])))
            {
                maxBeauty = Math.Max(maxBeauty, b);
                if (!dict.ContainsKey(p))
                    dict.Add(p, maxBeauty);
                else
                    dict[p] = maxBeauty;
            }

            var arr = items.Select(it => it[0]).Distinct().ToArray();
            var res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var key = queries[i];
                if (dict.ContainsKey(key))
                    res[i] = dict[key];
                else
                {
                    var idx = Array.BinarySearch(arr, 0, arr.Length, key);  //returns bitwise neg. index of the first element GREATER than key
                    idx = ~idx;
                    res[i] = idx > 0 ? dict[arr[idx-1]] : 0;
                }
            }
            return res;
        }
    }
}
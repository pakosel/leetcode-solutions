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
            var set = new SortedSet<int>();
            foreach ((int p, int b) in items.Select(it => (it[0], it[1])))
            {
                set.Add(p);
                maxBeauty = Math.Max(maxBeauty, b);
                if (!dict.ContainsKey(p))
                    dict.Add(p, maxBeauty);
                else
                    dict[p] = maxBeauty;
            }

            var arr = set.ToArray();
            var res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var key = queries[i];
                if (dict.ContainsKey(key))
                    res[i] = dict[key];
                else
                    res[i] = BinSearch(key);
            }
            return res;

            int BinSearch(int val)
            {
                var left = 0;
                var right = arr.Length - 1;
                if (val < arr[left])
                    return 0;
                if (val > arr[right])
                    return dict[arr[right]];
                
                int mid = 0;
                while(left < right)
                {
                    mid = left + (right - left) / 2;
                    if(val == arr[mid])
                        return dict[arr[mid]];
                    if(val > arr[mid])
                        if(val < arr[mid+1])
                            break;
                        else
                            left = mid + 1;
                    else
                        if(val > arr[mid-1])
                            return dict[arr[mid-1]];
                        else
                            right = mid - 1;
                }

                return dict[arr[mid]];
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace PartitionLabels
{
    public class Solution
    {
        public IList<int> PartitionLabels(string s)
        {
            const int NS = 1000;
            var arr = new (int b, int e)[26];
            Array.Fill(arr, (NS, NS));
            var res = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (arr[c - 'a'].b == NS)
                {
                    arr[c - 'a'].b = i;
                    arr[c - 'a'].e = i;
                }
                else
                    arr[c - 'a'].e = i;
            }
            Array.Sort(arr, (p1, p2) => p1.b == p2.b ? p1.e.CompareTo(p2.e) : p1.b.CompareTo(p2.b));

            var start = arr[0].b;
            var end = arr[0].e;
            foreach (var p in arr)
                if (p.b == NS)
                    break;
                else if (p.b <= end)
                    end = Math.Max(end, p.e);
                else
                {
                    res.Add(end - start + 1);
                    start = p.b;
                    end = p.e;
                }
            res.Add(end - start + 1);

            return res;
        }
    }
}
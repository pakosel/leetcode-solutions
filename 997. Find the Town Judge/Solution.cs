using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheTownJudge
{
    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            var tr = new HashSet<int>[n + 1];
            var hashSet = new HashSet<int>();
            for (int i = 1; i <= n; i++)
                hashSet.Add(i);

            foreach (var pair in trust)
            {
                var trustee = pair[1];
                if (tr[trustee] == null)
                    tr[trustee] = new HashSet<int>();
                tr[trustee].Add(pair[0]);
                hashSet.Remove(pair[0]);
            }
            if (hashSet.Count != 1)
                return -1;
            var judge = hashSet.First();
            var trusts = tr[judge]?.Count ?? 0;

            return trusts == n - 1 ? judge : -1;
        }
    }
}
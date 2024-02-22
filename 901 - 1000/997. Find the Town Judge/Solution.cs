using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace FindTheTownJudge
{
    public class Solution_2024
    {
        public int FindJudge(int n, int[][] trust)
        {
            var arr = new int[n + 1];
            var arrT = new int[n + 1];
            foreach (var p in trust)
            {
                arr[p[0]]++;
                arrT[p[1]]++;
            }
            for (int i = 1; i <= n; i++)
                if (arr[i] == 0 && arrT[i] == n - 1)
                    return i;
            return -1;
        }
    }
    
    public class Solution_2022
    {
        public int FindJudge(int n, int[][] trust)
        {
            if (trust.Length == 0)
                return n == 1 ? 1 : -1;
            var dict = trust.GroupBy(t => t[1]).ToDictionary(g => g.Key, g => g.Count());

            var judges = dict.Where(kvp => kvp.Value == n - 1);
            var res = judges.Count() == 1 ? judges.First().Key : -1;
            if (res != -1 && trust.All(t => t[0] != res))
                return res;
            return -1;
        }
    }

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
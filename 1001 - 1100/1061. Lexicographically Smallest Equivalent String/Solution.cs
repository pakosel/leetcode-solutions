using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LexicographicallySmallestEquivalentString
{
    public class Solution
    {
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            var arr = Enumerable.Range(0, 26).Select(_ => new HashSet<char>()).ToArray();

            for (int i = 0; i < s1.Length; i++)
                AddEdge(s1[i], s2[i]);
            var memo = new char[26];
            Array.Fill(memo, '-');

            var res = new StringBuilder();
            foreach (var c in baseStr)
                res.Append(memo[c - 'a'] != '-' ? memo[c - 'a'] : dfs(c, new HashSet<char>()));

            return res.ToString();

            char dfs(char c, HashSet<char> visited)
            {
                if (visited.Contains(c))
                    return c;
                var res = c;
                visited.Add(c);
                foreach (var dest in arr[c - 'a'])
                {
                    var b = dfs(dest, visited);
                    if (b < res)
                        res = b;
                }
                foreach (var x in visited)
                    memo[x - 'a'] = res;
                return res;
            }

            void AddEdge(char c1, char c2)
            {
                arr[c1 - 'a'].Add(c2);
                arr[c2 - 'a'].Add(c1);
            }
        }
    }
}
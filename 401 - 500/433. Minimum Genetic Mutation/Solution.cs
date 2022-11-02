using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace MinimumGeneticMutation
{
    public class Solution
    {
        public int MinMutation(string start, string end, string[] bank)
        {
            var graph = new Dictionary<string, HashSet<string>>();
            graph.Add(start, new HashSet<string>());
            foreach (var el in bank)
            {
                if (!graph.ContainsKey(el))
                    graph.Add(el, new HashSet<string>());
                if (CanMutate(start, el))
                    graph[start].Add(el);
            }

            for (int i = 0; i < bank.Length; i++)
                for (int j = i + 1; j < bank.Length; j++)
                    if (CanMutate(bank[i], bank[j]))
                    {
                        graph[bank[i]].Add(bank[j]);
                        graph[bank[j]].Add(bank[i]);
                    }

            var res = Dfs(start, new HashSet<string>(), 0);
            return res != int.MaxValue ? res : -1;

            int Dfs(string start, HashSet<string> visited, int path)
            {
                if (graph[start].Contains(end))
                    return path + 1;
                visited.Add(start);
                var min = int.MaxValue;
                foreach (var n in graph[start])
                    if (!visited.Contains(n))
                        min = Math.Min(min, Dfs(n, visited, path + 1));
                visited.Remove(start);
                return min;
            }

            bool CanMutate(string s1, string s2)
            {
                var diff = false;
                for (int i = 0; i < s1.Length; i++)
                    if (s1[i] != s2[i])
                        if (!diff)
                            diff = true;
                        else
                            return false;
                return true;
            }
        }
    }
}
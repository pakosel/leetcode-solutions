using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace EvaluateDivision
{
    public class Solution
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            Dictionary<string, Dictionary<string, double>> dict = new();
            for (int i = 0; i < equations.Count; i++)
            {
                var p0 = equations[i][0];
                var p1 = equations[i][1];
                if (!dict.ContainsKey(p0))
                    dict.Add(p0, new());
                if (!dict.ContainsKey(p1))
                    dict.Add(p1, new());
                dict[p0].Add(p1, values[i]);
                dict[p1].Add(p0, 1.0 / values[i]);
            }

            var res = new double[queries.Count];
            for (int i = 0; i < queries.Count; i++)
                res[i] = Math.Round(Dfs(dict, queries[i][0], queries[i][1], 1.0, new HashSet<string>()), 5);

            return res;
        }

        private double Dfs(Dictionary<string, Dictionary<string, double>> dict, string start, string end, double val, HashSet<string> visited)
        {
            if (visited.Contains(start) || !dict.ContainsKey(start))
                return -1;
            visited.Add(start);
            if (start == end)
                return val;
            foreach (var kvp in dict[start])
                if(Dfs(dict, kvp.Key, end, val * kvp.Value, visited) is var v && v != -1)
                    return v;

            return -1;
        }
    }
}
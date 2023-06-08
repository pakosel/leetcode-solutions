using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace TimeNeededToInformAllEmployees
{
    public class Solution
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            var subordinates = new List<int>[n];
            for (int i = 0; i < n; i++)
                if (manager[i] != -1)
                {
                    if (subordinates[manager[i]] == null)
                        subordinates[manager[i]] = new List<int>();
                    subordinates[manager[i]].Add(i);
                }
            var res = 0;
            Dfs(headID, 0);

            return res;

            void Dfs(int node, int time)
            {
                if (subordinates[node] == null)
                    res = Math.Max(res, time);
                else
                    foreach (var sub in subordinates[node])
                        Dfs(sub, time + informTime[node]);
            }
        }
    }
}
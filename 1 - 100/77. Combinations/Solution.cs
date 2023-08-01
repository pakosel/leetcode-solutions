using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace Combinations
{
    public class Solution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var res = new List<IList<int>>();
            for (int i = 1; i <= n; i++)
            {
                var lst = new List<int>() { i };
                res.AddRange(Dfs(lst, k - 1));
            }
            return res;

            IList<IList<int>> Dfs(List<int> lst, int k)
            {
                if (k == 0)
                    return new List<IList<int>>() { lst };
                var res = new List<IList<int>>();
                for (int i = lst.Last() + 1; i <= n; i++)
                    if (n - i + 1 >= k)
                    {
                        var lst2 = new List<int>(lst);
                        lst2.Add(i);
                        res.AddRange(Dfs(lst2, k - 1));
                    }
                    else
                        break;
                return res;
            }
        }
    }
}
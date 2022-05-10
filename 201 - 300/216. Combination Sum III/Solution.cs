using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CombinationSumIII
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum3(int k, int n, int start = 1)
        {
            var res = new List<IList<int>>();
            if (k == 2)
                for (int i = start; i < 10 && i < n; i++)
                {
                    var lookfor = n - i;
                    if(lookfor <= i)
                        break;
                    if (lookfor < 10)
                        res.Add(new List<int>() { i, lookfor });
                }
            else
                for (int i = start; i < 10 && i < n; i++)
                    foreach (var e in CombinationSum3(k - 1, n - i, i + 1))
                    {
                        e.Add(i);
                        res.Add(e);
                    }
            return res;
        }
    }
}
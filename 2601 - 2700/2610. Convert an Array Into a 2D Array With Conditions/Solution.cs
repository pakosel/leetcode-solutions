using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ConvertArrayInto2DArrayWithConditions
{
    public class Solution
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            var res = new List<HashSet<int>>();
            res.Add(new HashSet<int>());
            foreach (var n in nums)
            {
                var added = false;
                foreach (var hs in res)
                    if (!hs.Contains(n))
                    {
                        hs.Add(n);
                        added = true;
                        break;
                    }
                if (!added)
                    res.Add(new HashSet<int>() { n });
            }
            return res.Select(e => e.ToList()).ToList<IList<int>>();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;

namespace PascalTriangleII
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var res = new List<int>() { 1 };
            while (rowIndex-- > 0)
            {
                var newRes = new List<int>() { 1 };
                for (int i = 1; i < res.Count; i++)
                    newRes.Add(res[i] + res[i - 1]);
                newRes.Add(1);
                res = newRes;
            }
            return res;
        }
    }
}
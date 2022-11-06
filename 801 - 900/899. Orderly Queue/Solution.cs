using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace OrderlyQueue
{
    public class Solution
    {
        public string OrderlyQueue(string s, int k)
        {
            if (k == 1)
                return BestRotation(s.ToList());

            return string.Join("", s.OrderBy(_ => _));

            string BestRotation(List<char> str)
            {
                var min = string.Join("", str);

                for (int i = 1; i < str.Count; i++)
                {
                    str.Add(str[0]);
                    str.RemoveAt(0);
                    var curr = string.Join("", str);

                    if (string.Compare(curr, min) < 0)
                        min = curr;
                }
                return min;
            }
        }
    }
}
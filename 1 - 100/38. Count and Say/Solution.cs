using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace CountAndSay
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            var curr = "1";
            var next = new StringBuilder();
            while (--n > 0)
            {
                next.Clear();
                var i = 0;
                var digit = curr[i];
                var cnt = 1;
                while (++i < curr.Length)
                {
                    if (curr[i] != digit)
                    {
                        next.Append($"{cnt}{digit}");
                        digit = curr[i];
                        cnt = 0;
                    }
                    cnt++;
                }
                next.Append($"{cnt}{digit}");
                curr = next.ToString();
            }
            return curr;
        }
    }
}
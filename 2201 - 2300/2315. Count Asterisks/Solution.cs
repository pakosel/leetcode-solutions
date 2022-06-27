using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CountAsterisks
{
    public class Solution
    {
        public int CountAsterisks(string s)
        {
            var opened = false;
            var curr = 0;
            var res = 0;
            foreach (var c in s)
                if (c == '|')
                {
                    if (!opened)
                        res += curr;
                    else
                        curr = 0;
                    opened = !opened;
                }
                else if (c == '*')
                    curr++;
            res += curr;
            return res;
        }
    }
}
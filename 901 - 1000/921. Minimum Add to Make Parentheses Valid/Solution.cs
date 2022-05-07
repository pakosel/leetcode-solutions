using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace MinimumAddParentheses
{
    public class Solution
    {
        public int MinAddToMakeValid(string S)
        {
            var balanceOpened = 0;
            var balanceClosed = 0;
            
            foreach(var c in S)
            {
                if (c == '(')
                    balanceOpened++;
                else if (balanceOpened > 0)
                    balanceOpened--;
                else
                    balanceClosed++;
            }

            return balanceOpened + balanceClosed;
        }
    }
}
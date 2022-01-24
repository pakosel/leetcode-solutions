using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace CheckIfAllAsAppearsBeforeAllBs
{
    public class Solution
    {
        public bool CheckString(string s)
        {
            int i = 0;
            while (i < s.Length)
                if (s[i++] != 'a')
                    break;
            while (i < s.Length)
                if (s[i++] != 'b')
                    return false;
            return true;
        }
    }
}
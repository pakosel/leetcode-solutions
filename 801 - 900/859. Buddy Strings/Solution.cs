using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace BuddyStrings
{
    public class Solution
    {
        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;
            bool done = false;
            int pos = -1;
            for (int i = 0; i < s.Length; i++)
                if (s[i] != goal[i])
                    if (done)
                        return false;
                    else if (pos == -1)
                        pos = i;
                    else
                    {
                        if (s[i] == goal[pos] && s[pos] == goal[i])
                            done = true;
                        else
                            return false;
                    }
            return done || (pos == -1 && s.Distinct().Count() < s.Length);
        }
    }
}
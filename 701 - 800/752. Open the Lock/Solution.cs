using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace OpenTheLock
{
    public class Solution
    {
        public int OpenLock(string[] deadends, string target)
        {
            var end = new HashSet<string>(deadends);
            var processed = new HashSet<string>();
            var q = new Queue<(string s, int turns)>();
            q.Enqueue(("0000", 0));

            while (q.Count > 0)
            {
                var curr = q.Dequeue();
                if (curr.s == target)
                    return curr.turns;
                if (end.Contains(curr.s) || processed.Contains(curr.s))
                    continue;
                processed.Add(curr.s);
                for (int i = 0; i < 4; i++)
                {
                    q.Enqueue((Turn(curr.s, i, 1), curr.turns + 1));
                    q.Enqueue((Turn(curr.s, i, -1), curr.turns + 1));
                }
            }

            return -1;

            static string Turn(string s, int pos, int val)
            {
                var prefix = s[..pos];
                var suffix = s[(pos + 1)..];
                var nval = (s[pos] - '0' + val) % 10;
                if (nval == -1)
                    nval = 9;
                return prefix + nval + suffix;
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace PathCrossing
{
    public class Solution
    {
        public bool IsPathCrossing(string path)
        {
            var visited = new HashSet<(int, int)>();

            var curr = (0, 0);
            visited.Add(curr);
            foreach (var p in path)
            {
                curr = Add(p, curr);
                if (visited.Contains(curr))
                    return true;
                visited.Add(curr);
            }
            return false;

            (int, int) Add(char c, (int x, int y) p)
            {
                if (c == 'N')
                    return (p.x, p.y + 1);
                if (c == 'S')
                    return (p.x, p.y - 1);
                if (c == 'E')
                    return (p.x + 1, p.y);
                return (p.x - 1, p.y);
            }
        }
    }
}
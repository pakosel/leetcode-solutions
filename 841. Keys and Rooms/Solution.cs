using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KeysAndRooms
{
    public class Solution
    {
        HashSet<int> visited = new HashSet<int>();
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            Visit(rooms, 0);

            return visited.Count == rooms.Count;
        }

        private void Visit(IList<IList<int>> rooms, int r)
        {
            if (visited.Contains(r))
                return;
            visited.Add(r);
            foreach (var k in rooms[r])
                Visit(rooms, k);
        }
    }
}
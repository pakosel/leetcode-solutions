using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace KeysAndRooms
{
    public class Solution_2022
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var q = new Queue<int>();
            q.Enqueue(0);
            var visited = new HashSet<int>();
            while (q.Count > 0 && visited.Count < rooms.Count)
            {
                var curr = q.Dequeue();
                if (visited.Contains(curr))
                    continue;
                visited.Add(curr);
                foreach (var r in rooms[curr])
                    if (!visited.Contains(r))
                        q.Enqueue(r);
            }
            return visited.Count == rooms.Count;
        }
    }
    
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
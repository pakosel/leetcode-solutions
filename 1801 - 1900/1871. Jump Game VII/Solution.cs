using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace JumpGameVII
{
    public class Solution_DP
    {
        public bool CanReach(string s, int minJump, int maxJump)
        {
            var len = s.Length;
            if (s[len - 1] == '1')
                return false;
            var visited = new bool[len];
            var maxVisited = 0;
            visited[0] = true;

            for (int i = 0; i < len - 1; i++)
            {
                if (!visited[i])
                    continue;

                var start = Math.Max(i + minJump, maxVisited);
                var end = Math.Min(i + maxJump, len - 1);

                for (int j = start; j <= end; j++)
                {
                    if (j == len - 1)
                        return true;
                    if (s[j] == '0')
                        visited[j] = true;
                    maxVisited = Math.Max(maxVisited, j);
                }
            }
            return false;
        }
    }

    public class Solution_Queue
    {
        public bool CanReach(string s, int minJump, int maxJump)
        {
            var len = s.Length;
            if (s[len - 1] == '1')
                return false;
            var visited = new bool[len];
            var maxQueued = 0;
            var queue = new Queue<int>();
            queue.Enqueue(0);
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (visited[curr])
                    continue;
                visited[curr] = true;
                var start = Math.Max(curr + minJump, maxQueued + 1);
                for (int j = start; j <= Math.Min(curr + maxJump, len - 1); j++)
                {
                    if (j == len - 1)
                        return true;
                    if (j > len - 1)
                        break;
                    if (s[j] == '1' || visited[j])
                        continue;

                    queue.Enqueue(j);
                    maxQueued = j;
                }
            }
            return false;
        }
    }
}
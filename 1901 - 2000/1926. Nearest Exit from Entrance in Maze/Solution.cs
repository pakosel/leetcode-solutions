using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NearestExitFromEntranceInMaze
{
    public class Solution
    {
        public int NearestExit(char[][] maze, int[] entrance)
        {
            var rows = maze.Length;
            var cols = maze[0].Length;
            var queue = new Queue<(int r, int c, int steps)>();
            Enqueue((entrance[0], entrance[1], 0));
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                if (curr.r == 0 || curr.r == rows - 1 || curr.c == 0 || curr.c == cols - 1)
                    return curr.steps;
                Enqueue(curr);
            }

            return -1;

            void Enqueue((int r, int c, int steps) t)
            {
                maze[t.r][t.c] = 'X';
                if (t.r + 1 < rows && maze[t.r + 1][t.c] == '.')
                {
                    queue.Enqueue((t.r + 1, t.c, t.steps + 1));
                    maze[t.r + 1][t.c] = 'x';
                }
                if (t.r - 1 >= 0 && maze[t.r - 1][t.c] == '.')
                {
                    queue.Enqueue((t.r - 1, t.c, t.steps + 1));
                    maze[t.r - 1][t.c] = 'x';
                }
                if (t.c + 1 < cols && maze[t.r][t.c + 1] == '.')
                {
                    queue.Enqueue((t.r, t.c + 1, t.steps + 1));
                    maze[t.r][t.c + 1] = 'x';
                }
                if (t.c - 1 >= 0 && maze[t.r][t.c - 1] == '.')
                {
                    queue.Enqueue((t.r, t.c - 1, t.steps + 1));
                    maze[t.r][t.c - 1] = 'x';
                }
            }
        }
    }
}
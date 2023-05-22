using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ShortestBridge
{
    public class Solution
    {
        public int ShortestBridge(int[][] grid)
        {
            const int MAX = int.MaxValue - 1;
            var STEPS = new (int r, int c)[] {(-1, 0), (1, 0), (0, -1), (0, 1)};
            var n = grid.Length;
            var res = MAX;
            var islandNo = 0;
            var dist = new int?[n, n, 2];   //distance of (r, c) cell from z-th island
            var waterCells = new Queue<(int r, int c)>[] {new Queue<(int r, int c)>(), new Queue<(int r, int c)>()};

            //map each island
            for (int i = 0; i < n && islandNo < 2; i++)
                for (int j = 0; j < n && islandNo < 2; j++)
                    if (grid[i][j] == 1 && !dist[i, j, 0].HasValue)
                        dfsMapIsland(i, j, islandNo++);

            //process water cells to calc min bridge len
            for(int i=0; i<2; i++)
                while(waterCells[i].Count > 0)
                {
                    var curr = waterCells[i].Dequeue();
                    var path = TakeMinPath(curr.r, curr.c, i);
                    dist[curr.r, curr.c, i] = path;

                    if (dist[curr.r, curr.c, (i + 1) % 2].HasValue)
                        res = Math.Min(res, dist[curr.r, curr.c, (i + 1) % 2].Value + path);
                    AddWaterCells(curr, i);
                }

            return res - 1;

            void dfsMapIsland(int r, int c, int island)
            {
                if (r < 0 || c < 0 || r == n || c == n || dist[r, c, island].HasValue || grid[r][c] == 0)
                    return;
                dist[r, c, island] = 0;
                AddWaterCells((r, c), island);
                foreach(var step in STEPS)
                    dfsMapIsland(r + step.r, c + step.c, island);
            }

            void AddWaterCells((int r, int c) cell, int island)
            {
                foreach(var step in STEPS)
                {
                    var tgt = (cell.r + step.r, cell.c + step.c);
                    if(NeedsVisit(tgt, island) && !waterCells[island].Contains(tgt))
                        waterCells[island].Enqueue(tgt);
                }
            }

            bool NeedsVisit((int r, int c) cell, int island)
            {
                if(cell.r < 0 || cell.r >= n || cell.c < 0 || cell.c >= n)
                    return false;
                return grid[cell.r][cell.c] == 0 && !dist[cell.r, cell.c, island].HasValue;
            }

            int TakeMinPath(int r, int c, int island)
            {
                var min = MAX;
                foreach(var step in STEPS)
                {
                    var tgtR = r + step.r;
                    var tgtC = c + step.c;
                    if(tgtR >= 0 && tgtR < n && tgtC >= 0 && tgtC < n)
                        min = Math.Min(min, dist[tgtR, tgtC, island].HasValue ? dist[tgtR, tgtC, island].Value + 1 : MAX);
                }
                return min;
            }
        }
    }
}
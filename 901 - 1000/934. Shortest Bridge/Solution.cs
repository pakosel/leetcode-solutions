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
            var n = grid.Length;
            var res = int.MaxValue;
            var islandNo = 0;
            var dist = new int?[n, n, 2];
            var island_0 = new HashSet<(int, int)>();
            var edgeTiles = new List<(int x, int y)>();

            for (int i = 0; i < n && islandNo < 2; i++)
                for (int j = 0; j < n && islandNo < 2; j++)
                    if (grid[i][j] == 1 && !island_0.Contains((i, j)))
                        dfsMap(i, j, islandNo++);

            foreach (var et in edgeTiles)
                dfsDist(et.x, et.y, island_0.Contains((et.x, et.y)) ? 0 : 1, -1);

            return res - 1;

            void dfsMap(int x, int y, int island)
            {
                if (x < 0 || y < 0 || x == n || y == n || dist[x, y, island].HasValue || grid[x][y] == 0)
                    return;
                dist[x, y, island] = 0;
                if (island == 0)
                    island_0.Add((x, y));
                if (IsEdgeTile(x, y))
                    edgeTiles.Add((x, y));
                dfsMap(x + 1, y, island);
                dfsMap(x - 1, y, island);
                dfsMap(x, y + 1, island);
                dfsMap(x, y - 1, island);
            }

            bool IsEdgeTile(int x, int y)
            {
                if (x - 1 >= 0 && grid[x - 1][y] == 0)
                    return true;
                if (x + 1 < n && grid[x + 1][y] == 0)
                    return true;
                if (y - 1 >= 0 && grid[x][y - 1] == 0)
                    return true;
                if (y + 1 < n && grid[x][y + 1] == 0)
                    return true;
                return false;
            }

            void dfsDist(int x, int y, int island, int path)
            {
                if (x < 0 || y < 0 || x == n || y == n ||
                   (dist[x, y, island].HasValue && dist[x, y, island].Value <= path))
                    return;
                if (path < 0)
                    path = 0;
                dist[x, y, island] = path;
                if (dist[x, y, (island + 1) % 2].HasValue)
                    res = Math.Min(res, dist[x, y, (island + 1) % 2].Value + path);
                dfsDist(x + 1, y, island, path + 1);
                dfsDist(x - 1, y, island, path + 1);
                dfsDist(x, y + 1, island, path + 1);
                dfsDist(x, y - 1, island, path + 1);
            }
        }
    }
}
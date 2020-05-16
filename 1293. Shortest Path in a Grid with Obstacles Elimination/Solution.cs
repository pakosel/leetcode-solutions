using System.Collections.Generic;
using System.Linq;
using System;
using System.Drawing;
using System.Text;

namespace ShortestPathInGridWithObstacles
{
    public class Solution
    {
        Dictionary<Point, int> visitedNodes = new Dictionary<Point, int>();
        Queue<PointPathCredit> queue = new Queue<PointPathCredit>();
        Point final;
        int[][] Grid;
        public int ShortestPath(int[][] grid, int k)
        {
            if (grid.Length == 0)
                return 0;

            Grid = grid;
            queue.Enqueue(new PointPathCredit(new Point(0, 0), 0, k));
            final = new Point(grid.Length - 1, grid[0].Length - 1);

            while (queue.Count > 0)
            {
                var ppc = queue.Dequeue();
                var point = ppc.Point;
                var path = ppc.Path;
                var credit = ppc.Credit;
                if (point == final)
                    return path;

                if (visitedNodes.ContainsKey(point))
                {
                    if (visitedNodes[point] < credit)
                        visitedNodes[point] = credit;
                    else
                        continue;
                }
                else
                    visitedNodes.Add(point, credit);

                ProcessPoint(point.X + 1, point.Y, credit, path);
                ProcessPoint(point.X, point.Y + 1, credit, path);
                ProcessPoint(point.X - 1, point.Y, credit, path);
                ProcessPoint(point.X, point.Y - 1, credit, path);
            }

            return -1;
        }

        private void ProcessPoint(int x, int y, int currentCredit, int currentPath)
        {
            if (x >= 0 && x <= final.X && y >= 0 && y <= final.Y)
            {
                var p = new Point(x, y);
                var nextCredit = currentCredit - Grid[x][y];
                if (nextCredit >= 0 && (!visitedNodes.ContainsKey(p) || visitedNodes[p] < nextCredit))
                    queue.Enqueue(new PointPathCredit(p, currentPath + 1, nextCredit));
            }
        }

        private struct PointPathCredit
        {
            public Point Point;
            public int Path;
            public int Credit;

            public PointPathCredit(Point point, int path, int credit)
            {
                Point = point;
                Path = path;
                Credit = credit;
            }
        }
    }
}
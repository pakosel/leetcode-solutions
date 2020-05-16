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
        Point final;
        int[][] Grid;
        public int ShortestPath(int[][] grid, int k)
        {
            if (grid.Length == 0)
                return 0;
            
            Grid = grid;
            //Tuple<Point, path, credit>
            Queue<Tuple<Point, int, int>> queue = new Queue<Tuple<Point, int, int>>();
            queue.Enqueue(new Tuple<Point, int, int>(new Point(0, 0), 0, k));
            final = new Point(grid.Length - 1, grid[0].Length - 1);

            while (queue.Count > 0)
            {
                var tuple = queue.Dequeue();
                var point = tuple.Item1;
                var path = tuple.Item2;
                var credit = tuple.Item3;
                if (point == final)
                    return path;

                if (visitedNodes.ContainsKey(point))
                {
                    if(visitedNodes[point] < credit)
                        visitedNodes[point] = credit;
                    else
                        continue;
                }
                else
                    visitedNodes.Add(point, credit);

                var nextPoint = new Point(point.X + 1, point.Y);
                if(ValidateNextPoint(nextPoint, credit, out var nextCredit))
                    queue.Enqueue(new Tuple<Point, int, int>(nextPoint, path+1, nextCredit));
                nextPoint = new Point(point.X, point.Y + 1);
                if(ValidateNextPoint(nextPoint, credit, out nextCredit))
                    queue.Enqueue(new Tuple<Point, int, int>(nextPoint, path+1, nextCredit));
                nextPoint = new Point(point.X - 1, point.Y);
                if(ValidateNextPoint(nextPoint, credit, out nextCredit))
                    queue.Enqueue(new Tuple<Point, int, int>(nextPoint, path+1, nextCredit));
                nextPoint = new Point(point.X, point.Y - 1);
                if(ValidateNextPoint(nextPoint, credit, out nextCredit))
                    queue.Enqueue(new Tuple<Point, int, int>(nextPoint, path+1, nextCredit));
            }

            return -1;
        }

        bool ValidateNextPoint(Point p, int credit, out int nextCredit)
        {
            nextCredit = -1;
            if(p.X >= 0 && p.X <= final.X && p.Y >= 0 && p.Y <= final.Y)
            {
                nextCredit = credit - Grid[p.X][p.Y];
                if(nextCredit >= 0 && (!visitedNodes.ContainsKey(p) || visitedNodes[p] < nextCredit))
                    return true;
            }
            return false;
            
        }
    }
}
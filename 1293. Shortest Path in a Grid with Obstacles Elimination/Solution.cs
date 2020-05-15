using System.Collections.Generic;
using System.Linq;
using System;
using System.Drawing;
using System.Text;

namespace ShortestPathInGridWithObstacles
{
    public class Solution
    {
        Dictionary<Point, Node> visitedNodes = new Dictionary<Point, Node>();
        public int ShortestPath(int[][] grid, int k)
        {
            if (grid.Length == 0)
                return 0;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(0, 0, k, 0, grid));

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.IsFinal)
                    return node.Path;

                if (visitedNodes.ContainsKey(node.Point))
                {
                    if(visitedNodes[node.Point].Credit < node.Credit)
                        visitedNodes[node.Point] = node;
                    else
                        continue;
                }
                else
                    visitedNodes.Add(node.Point, node);

                foreach (var n in node.Neighbours(visitedNodes))
                    queue.Enqueue(n);
            }

            return -1;
        }
    }

    public class Node
    {
        int X;
        int Y;
        public Point Point => new Point(X, Y);
        public int Credit;
        public int Path;
        int[][] Grid;
        int GridWidth => Grid.Length;
        int GridHeight => Grid[0].Length;
        public bool IsFinal => X == GridWidth - 1 && Y == GridHeight - 1;
        public Node(int x, int y, int credit, int path, int[][] grid)
        {
            X = x;
            Y = y;
            Credit = credit - grid[x][y];
            Path = path;
            Grid = grid;
        }

        public IEnumerable<Node> Neighbours(Dictionary<Point, Node> visitedNodes)
        {
            var candidates = new List<Node>();
            if (X < GridWidth - 1)
                candidates.Add(new Node(X + 1, Y, Credit, Path + 1, Grid));
            if (Y < GridHeight - 1)
                candidates.Add(new Node(X, Y + 1, Credit, Path + 1, Grid));
            if (X > 0)
                candidates.Add(new Node(X - 1, Y, Credit, Path + 1, Grid));
            if (Y > 0)
                candidates.Add(new Node(X, Y - 1, Credit, Path + 1, Grid));

            foreach (var candidate in candidates)
                if (candidate.Credit >= 0)
                {
                    var visited = visitedNodes.ContainsKey(candidate.Point) ? visitedNodes[candidate.Point] : null;
                    if (visited == null || visited.Credit < candidate.Credit)
                        yield return candidate;
                }
        }
    }
}
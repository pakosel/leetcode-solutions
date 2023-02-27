using System.Collections.Generic;
using System.Linq;
using System;

namespace ConstructQuadTree
{
    public class Solution
    {
        public Node Construct(int[][] grid)
        {
            return Build(0, 0, grid.Length);

            Node Build(int r, int c, int len)
            {
                if (CheckSame(r, c, len))
                    return new Node(grid[r][c] == 1, true);
                else
                    return new Node(true, false, 
                                        Build(r, c, len / 2), 
                                        Build(r, c + len / 2, len / 2), 
                                        Build(r + len / 2, c, len / 2), 
                                        Build(r + len / 2, c + len / 2, len / 2));
            }

            bool CheckSame(int row, int col, int len)
            {
                var val = grid[row][col];
                for (int r = 0; r < len; r++)
                    for (int c = 0; c < len; c++)
                        if (grid[row + r][col + c] != val)
                            return false;
                return true;
            }
        }
    }

    // Definition for a QuadTree node.
    public class Node
    {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node()
        {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public Node(bool _val, bool _isLeaf)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }
}
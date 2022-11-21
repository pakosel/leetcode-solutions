using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace RectangleArea
{
    public class Solution
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            return Math.Abs(ax2 - ax1) * Math.Abs(ay2 - ay1) +
                    Math.Abs(bx2 - bx1) * Math.Abs(by2 - by1) -
                    CommonArea();

            int CommonArea()
            {
                int minY = 0, minX = 0;
                int maxY = Math.Min(by2, ay2);
                int maxX = Math.Min(ax2, bx2);

                if (bx1 >= ax1 && bx1 <= ax2)
                    minX = bx1;
                else if (ax1 >= bx1 && ax1 <= bx2)
                    minX = ax1;
                else
                    return 0;

                if ((by1 >= ay1 && by1 <= ay2))
                    minY = by1;
                else if ((ay1 >= by1 && ay1 <= by2))
                    minY = ay1;
                else
                    return 0;

                return Math.Abs(maxX - minX) * Math.Abs(maxY - minY);
            }
        }
    }
}
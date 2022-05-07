using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace KClosestPointsToOrigin
{
    public class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            Array.Sort(points, (p1, p2) => (p1[0]*p1[0] + p1[1]*p1[1]).CompareTo(p2[0]*p2[0] + p2[1]*p2[1]));

            return points.Take(k).ToArray();
        }
    }
}
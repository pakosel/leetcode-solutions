using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace ValidSquare
{
    public class Solution
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            HashSet<int> distinct = new HashSet<int>();
            distinct.Add(Dist(p1, p2));
            distinct.Add(Dist(p1, p3));
            distinct.Add(Dist(p1, p4));
            distinct.Add(Dist(p2, p3));
            distinct.Add(Dist(p2, p4));
            distinct.Add(Dist(p3, p4));

            return distinct.Count == 2 && !distinct.Contains(0);
        }

        private int Dist(int[] p1, int[] p2) => (p1[0] - p2[0]) * (p1[0] - p2[0]) + (p1[1] - p2[1]) * (p1[1] - p2[1]);
    }
}
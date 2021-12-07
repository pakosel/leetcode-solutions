using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace NumberOfPairsOfInterchangeableRectangles
{
    public class Solution
    {
        public long InterchangeableRectangles(int[][] rectangles)
        {
            var dict = new Dictionary<decimal, int>();
            long sum = 0;
            foreach (var rect in rectangles)
            {
                var d = Decimal.Divide(rect[0], rect[1]);
                if (dict.ContainsKey(d))
                {
                    sum += dict[d];
                    dict[d]++;
                }
                else
                    dict.Add(d, 1);
            }
            return sum;
        }
    }
}
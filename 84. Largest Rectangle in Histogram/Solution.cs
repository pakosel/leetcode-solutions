using System.Collections.Generic;
using System.Linq;
using System;

namespace LargestRectangleHistogram
{
    public class Solution
    {
        Stack<int> stack = new Stack<int>();

        public int LargestRectangleArea(int[] heights)
        {
            int len = heights.Length;
            if (len == 0)
                return 0;

            int max = -1;
            int i = 0;
            while (i < len)
            {
                if (stack.Count == 0 || heights[stack.Peek()] <= heights[i])
                {
                    stack.Push(i);
                    i++;
                }
                else
                    max = Math.Max(max, calculateStackArea(heights, i));
            }

            while (stack.Count > 0)
                max = Math.Max(max, calculateStackArea(heights, i));

            return max;
        }

        private int calculateStackArea(int[] heights, int i)
        {
            int prev = stack.Pop();
            int barHeight = heights[prev];

            //for the given bar height get from the stack
            //multiply it's value as many times as bar height value (or more)
            //occured in the series since the last less value
            int stackPeek = stack.Count > 0 ? stack.Peek() + 1 : 0;
            int area = barHeight * (i - stackPeek);

            return area;
        }
    }
    /*
    5       x
    4     x x   x
    3     x x x x
    2   x x x x x
    1 x x x x x x
      0 1 2 3 4 5

    5     
    4           x
    3   x     x x
    2 x x     x x
    1 x x x   x x
      0 1 2 3 4 5
    */
}
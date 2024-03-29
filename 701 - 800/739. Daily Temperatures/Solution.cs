using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DailyTemperatures
{
    public class Solution_2022
    {
        public int[] DailyTemperatures(int[] temp)
        {
            var len = temp.Length;
            var res = new int[len];
            var stack = new Stack<int>();
            var idx = len - 1;
            stack.Push(idx);
            res[idx] = 0;
            while (--idx >= 0)
            {
                while (stack.Count > 0 && temp[stack.Peek()] <= temp[idx])
                    stack.Pop();
                if (stack.Count > 0)
                    res[idx] = stack.Peek() - idx;
                stack.Push(idx);
            }
            return res;
        }
    }
    public class Solution
    {
        const int T_MIN = 30;
        const int T_MAX = 100;
        public int[] DailyTemperatures(int[] temperatures)
        {
            var positions = new int[T_MAX - T_MIN + 1];
            int len = temperatures.Length;
            int[] res = new int[len];
            for (int i = len - 1; i >= 0; i--)
            {
                var t = temperatures[i];
                res[i] = FindWarmer(positions, t, i);
                positions[t - T_MIN] = i;
            }

            return res;
        }

        private int FindWarmer(int[] positions, int val, int currentPos)
        {
            var res = int.MaxValue;
            for (int i = val + 1 - T_MIN; i <= T_MAX - T_MIN; i++)
                if (positions[i] != 0)
                {
                    res = Math.Min(res, positions[i] - currentPos);
                    if (res == 1)
                        break;
                }
            return res == int.MaxValue ? 0 : res;
        }
    }
}
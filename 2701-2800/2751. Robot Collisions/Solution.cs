using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace RobotCollisions
{
    public class Solution
    {
        public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {
            var len = positions.Length;
            var pq = new PriorityQueue<(int pos, int h, char dir, int idx), int>();
            for (int i = 0; i < len; i++)
                pq.Enqueue((positions[i], healths[i], directions[i], i), positions[i]);
            var stack = new Stack<(int pos, int h, char dir, int idx)>();
            var res = new PriorityQueue<int, int>();
            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                if (curr.dir == 'R')
                    stack.Push(curr);
                else
                {
                    while (stack.Count > 0 && stack.Peek().h < curr.h)
                    {
                        stack.Pop();
                        curr.h--;
                    }
                    if (stack.Count == 0)
                        res.Enqueue(curr.h, curr.idx);
                    else
                    {
                        var pop = stack.Pop();
                        if (pop.h > curr.h)
                            stack.Push((pop.pos, pop.h - 1, pop.dir, pop.idx));
                    }
                }
            }
            while (stack.Count > 0)
                res.Enqueue(stack.Peek().h, stack.Pop().idx);
            var ans = new List<int>();
            while (res.Count > 0)
                ans.Add(res.Dequeue());
            return ans;
        }
    }
}